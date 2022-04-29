using UnityEngine;
using UnityEngine.Events;
using System;

[Serializable]
public class GameEventListener : MonoBehaviour
{
     [SerializeField]
    public ScriptableObjectEvent gameEvent;
     [SerializeField]
    public UnityEvent onEventTriggered;

    void OnEnable(){
        gameEvent.AddListener(this);
    }

    void OnDisable(){
        gameEvent.RemoveListener(this);
    }

    public void OnEventTriggered(){
        onEventTriggered.Invoke();
    }
}
