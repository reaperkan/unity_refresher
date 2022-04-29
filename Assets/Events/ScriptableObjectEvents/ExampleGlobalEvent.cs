using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleGlobalEvent : MonoBehaviour
{
    public ScriptableObjectEvent gameEvent;

    IEnumerator Start(){
        yield return new WaitForSeconds(3);
        gameEvent.TriggerEvent();
    }
}
