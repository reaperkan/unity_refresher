using UnityEngine;

public class HealthEventSytem : MonoBehaviour
{
    // The problem with this approach is that the delegate can be 
    // reassigned by other scripts and then can also be called by other script
    // which makes it prone to accidents 

    // To resolve this we use the event keyword
    // public static event TakeDamage onTakeDamage;
    // This makes it only possible to be invoked by the same script
    public delegate void TakeDamage(int damage);
    public static TakeDamage onTakeDamage;
        
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            onTakeDamage?.Invoke(30);
        }
    }
}
