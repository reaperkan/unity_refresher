using UnityEngine;
using System.Linq;

public class CullingGroupBehaviour : MonoBehaviour {
    CullingGroup localCullingGroup;

    MeshRenderer[] meshRenderers;
    Transform[] meshTransforms;
    BoundingSphere[] cullingPoints;

    private void OnEnable() {
        localCullingGroup = new CullingGroup();

        meshRenderers = FindObjectsOfType<MeshRenderer>()
                            .Where((MeshRenderer m) => m.gameObject != this.gameObject)
                            .ToArray();
        
        cullingPoints = new BoundingSphere[meshRenderers.Length];
        meshTransforms = new Transform[meshRenderers.Length];

        for( var i = 0; i < meshRenderers.Length; i++ ){
            meshTransforms[i] = meshRenderers[i].GetComponent<Transform>();
            cullingPoints[i].position = meshTransforms[i].position;
            cullingPoints[i].radius = 4f;
        }

        localCullingGroup.onStateChanged = CullingEvent;
        localCullingGroup.SetBoundingSpheres(cullingPoints);
        localCullingGroup.SetBoundingDistances(new float[] {0f,5f});
        localCullingGroup.SetDistanceReferencePoint(this.GetComponent<Transform>().position);
        localCullingGroup.targetCamera = Camera.main;
    }

    private void FixedUpdate() {
        localCullingGroup.SetDistanceReferencePoint(this.GetComponent<Transform>().position);
        for ( var i = 0; i<meshTransforms.Length; i++){
            cullingPoints[i].position = meshTransforms[i].position;
        }
    }

    void CullingEvent(CullingGroupEvent sphere){
        // can also do sphere.isVisible based on camera visibility
        // above similar effect can also be done using OnBecameVisible() 
        // if object has meshrenderer
        Color newColor = Color.red;
        if (sphere.currentDistance == 1) newColor = Color.blue;
        if (sphere.currentDistance == 2) newColor = Color.white;
        meshRenderers[sphere.index].material.color = newColor;
    }

    private void OnDisable() {
        localCullingGroup.Dispose();
    }
}