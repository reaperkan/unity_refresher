using UnityEngine;


// To Seperate Out Logic from Main MonoBehaviour
// We Can create lots of different behaviours this way
[CreateAssetMenu(menuName = "RaycastService")]
public class RaycastService : ScriptableObject
{
    [SerializeField]
    private LayerMask layerMask;

    public RaycastHit2D raycast2D(Vector2 origin, Vector2 direction, float distance){
        return Physics2D.Raycast(origin,direction,layerMask.value);
    }
}
