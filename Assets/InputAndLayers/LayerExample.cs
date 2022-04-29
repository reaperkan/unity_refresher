using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerExample : MonoBehaviour
{
    public int layerIndex = 0;

    public LayerMask layerMask;
    public Vector3 direction;

    void Start(){
        Collider[] colliders = Physics.OverlapSphere(transform.position, 5f,layerIndex);

        if(Physics.Raycast(transform.position, direction, 35f, layerMask)){
            Debug.Log("Raycast hit");
        }

        layerIndex = LayerMask.NameToLayer("Object");

    }

}

static class Utility {
    public static bool isInLayerMask(this GameObject @object, LayerMask layerMask){
        bool result = (1 << @object.layer & layerMask) == 0;
        return result;
    }
}
