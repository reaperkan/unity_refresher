using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    void FixedUpdate(){
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, fwd, 10f,
            LayerMask.NameToLayer("object"),QueryTriggerInteraction.Collide)){
                Debug.Log("Hit Someone");
        }
    }
}
