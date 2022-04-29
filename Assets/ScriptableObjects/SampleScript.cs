using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    [SerializeField]
    ExampleScriptableObject mySo;

    void OnEnable(){
        mySo.HelloWorld();
        // To Create a runtime instance
        // mySo=ScriptableObject.CreateInstance<ExampleScriptableObject>();

        // To find active scriptable objects during runtime
        // This is pretty slow so remember to cache them
        // Better to have a list of resources that we can fetch from
        // ExampleScriptableObject[] instances = Resources.FindObjectsOfTypeAll<ExampleScriptableObject>();
    }
}
