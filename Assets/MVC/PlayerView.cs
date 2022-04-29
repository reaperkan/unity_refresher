using UnityEngine;
// View -> should be the class to interact with UnityAPI
public class PlayerView : MonoBehaviour
{
   public void SetPosition(Vector3 position){
       transform.position = position;
   }
}
