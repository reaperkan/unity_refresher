using UnityEngine;

public class QuaternionExample : MonoBehaviour
{
    // Euler are rotation in degree angles
    // Quaternion represent a point in Unit Sphere

    void Start(){
        Quaternion rotation = Quaternion.Euler(Vector3.down);
        rotation = Quaternion.Euler(10,30,50);

        Quaternion rotInQot = transform.rotation;
        Debug.Log(rotInQot.eulerAngles);
        



        Vector3 targetPos = Vector3.forward * 10 + Vector3.up*40;

        // If we subtract like transform.position - targetPos
        // We get the angles 180 degrees off
        Quaternion newRotation = Quaternion.LookRotation(targetPos - transform.position);

    }
}
