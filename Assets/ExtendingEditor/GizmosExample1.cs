using UnityEditor;
using UnityEngine;

public class GizmosExample1 : MonoBehaviour
{
    public float GetDetectionRadius(){
        return 12.5f;
    }

    public float GetFOV(){
        return 25f;
    }

    public float GetMaxRange(){
        return 6.5f;
    }

    public float GetMinRange(){
        return 0;
    }

    public float GetAspect(){
        return 2.5f;
    }

    // private void OnDrawGizmos() {
    //     // Store gizmos and reassign them again to not affect other gizmos
    //     var gizmoMatrix = Gizmos.matrix;
    //     var gizmoColor = Gizmos.color;

    //     Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation,transform.lossyScale);
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawFrustum(Vector3.zero, GetFOV(), GetMaxRange(), GetMinRange(), GetAspect());

    //     Gizmos.matrix= gizmoMatrix;
    //     Gizmos.color = gizmoColor;
    // }

    // private void OnDrawGizmosSelected() {
    //     Handles.DrawWireDisc(transform.position,Vector3.up,GetDetectionRadius());
    // }
}
