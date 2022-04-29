using UnityEngine;

public class BoxColliderExample : MonoBehaviour
{
    void Start()
    {
        BoxCollider boxCollider = (BoxCollider)this.gameObject.AddComponent(typeof(BoxCollider));
        boxCollider.isTrigger = true;
        boxCollider.center = Vector3.zero;
        boxCollider.size *= 2;
    }
}
