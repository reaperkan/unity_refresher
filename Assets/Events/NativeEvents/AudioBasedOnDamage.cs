using UnityEngine;

public class AudioBasedOnDamage : MonoBehaviour
{
    void OnEnable()
    {
        HealthEventSytem.onTakeDamage += PlayDamageSound;
    }

    void OnDisable(){
        HealthEventSytem.onTakeDamage -= PlayDamageSound;
    }

    void PlayDamageSound(int damage){
        Debug.LogFormat("This is the damage {0}",damage);
    }
}
