using UnityEngine;
using UnityEngine.Events;
// UnityEvents are great for local scripts and components
// But since we have to do it manually for two unrelated objects
// it might be better to use event delegates
public class UnityEventsHealth : MonoBehaviour
{
    float health = 100;
    // We pass static parameter through the inspector
    public UnityEvent onPlayerDeath;
    // To be able to pass dynamic parameters we created a 
    // new class that inherits UnityEvents
    public FloatEvent onPlayerHurt;
    void TakeDamage(float damage){
        health -= damage;
        onPlayerHurt.Invoke(damage);
        if(health <= 0){
            // No need of null check as UnityEvent is a class in Unity
            // if it is null no errors will be generated
            onPlayerDeath.Invoke();
        }
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            TakeDamage(30);
        }
    }
}
