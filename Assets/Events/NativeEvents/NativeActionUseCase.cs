using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NativeActionUseCase : MonoBehaviour
{
    void OnEnable(){
        NativeActions.OnGameOver += GameOver;
    }

    void OnDisable(){
        NativeActions.OnGameOver -= GameOver;
    }

    void GameOver(string text){
        Debug.Log(text);
    }
}
