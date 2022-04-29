using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHealthBar : MonoBehaviour
{
    public void UpdateHealth(float damage){
        Debug.LogFormat("Updating Health Bar after damage {0}",damage);
    }
}
