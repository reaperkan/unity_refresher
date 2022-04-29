using UnityEngine;
using UnityEditor;


//Gets called whenever editor launches or recompiles
[InitializeOnLoad]
public class EditorAttributes : MonoBehaviour
{
    //Static constructor so this gets called first
    static EditorAttributes(){
        Debug.Log("Editor Attributes Constructor");
    }

    // Will get called after this class gets loaded
    //Order of execution of methods using this is not guranteed
    [InitializeOnLoadMethod]
    static void Foo(){
        Debug.Log("Editor Attributes Foo");
    }
}
