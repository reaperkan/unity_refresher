using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast2DExample : MonoBehaviour
{
    public LayerMask layerMask;

    void FixedUpdate(){
        RaycastHit2D hit = Physics2D.Raycast(transform.position,Vector2.down,1f,layerMask);

        if(hit.collider != null){
            Debug.Log("Hit Something");
        }
    }
}
