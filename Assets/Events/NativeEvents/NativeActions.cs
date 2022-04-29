using UnityEngine;
using System;
public class NativeActions : MonoBehaviour
{
    // System class provides Action
    // This means we dont have to manually define a delegate
    // the below code is the same as 
    // public delegate void OnGameOver();
    // public static event OnGameOver onGameOver;

    // If you want to return some value use Func
    public static event Action<string> OnGameOver;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Return)){
            OnGameOver?.Invoke("Die");
        }
    }

}
