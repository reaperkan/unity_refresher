using UnityEngine;

public class SphereColliderExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SphereCollider sphereCollider = (SphereCollider)this.gameObject.AddComponent(typeof(SphereCollider));
        sphereCollider.isTrigger = true;
        sphereCollider.center = Vector3.forward;
        sphereCollider.radius = 2;
    }
}
