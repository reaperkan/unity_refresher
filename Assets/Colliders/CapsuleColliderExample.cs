using UnityEngine;

public class CapsuleColliderExample : MonoBehaviour
{
    [Range(0,2)]
    public int direction = 0;
    // Start is called before the first frame update
    void Start()
    {
        CapsuleCollider capsuleCollider = (CapsuleCollider)this.gameObject.AddComponent(typeof(CapsuleCollider));

        capsuleCollider.isTrigger = true;
        capsuleCollider.center = Vector3.zero;

        capsuleCollider.height = 1;
        capsuleCollider.radius = 0.5f;
        capsuleCollider.direction = direction;
    }

    void Update(){
        this.GetComponent<CapsuleCollider>().direction = direction;
    }

}
