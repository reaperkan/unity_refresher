using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameManager", menuName = "Game Manager", order = 0)]
public class GameManager : SingletonScriptableObjectNamespace.SingletonScriptableObject<GameManager>{
    public int lives;
    public int points;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void BeforeSceneLoad(){
        BuildSingletonInstance();
    }

    public override void ScriptableObjectAwake()
    {
        Debug.Log(GetType().Name + " created");
    }

    public override void MonoAwake()
    {
        Debug.Log(GetType().Name + " awake");
        // To Use Mono specific things
        // Behaviour.StartCoroutine("")
    }

    public override void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Fire");
        }
    }
}
