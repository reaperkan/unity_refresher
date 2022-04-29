using UnityEngine;


// will call update when changes in the scene (editor refresh)
[ExecuteInEditMode]
public class EditorCommonAttributes : MonoBehaviour {
    

    //Called just after scene load default behaviour
    [RuntimeInitializeOnLoadMethod]
    private static void FooBar(){
        Debug.Log("FooBar");
    }

    // Before Scene loads
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Food(){
        Debug.Log("Foo");
    }

    // Default behaviour
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void Bar(){
        Debug.Log("Bar");
    }

    void Update(){
        if(Application.isEditor){
            // Debug.Log("Is Editor");
        }else{
            // Debug.Log("Is Bundled");
        }
    }
}