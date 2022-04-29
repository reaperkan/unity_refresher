using UnityEditor;
using UnityEngine;
// % - CTRL
// # - SHIFT
// & - ALT
public class MenuItemsExample : MonoBehaviour{
    [MenuItem("Example/DoSomething %#&d")]
    private static void DoSomething(){
        Debug.Log("DoSomething");
    }

    [MenuItem("Example/DoAnotherThing",true)]
    private static bool DoAnotherThingValidator(){
        return Selection.gameObjects.Length > 0;
    }

    [MenuItem("Example/DoAnotherThing _PGUP")]
    private static void DoAnotherThing(){
        Debug.Log("DoAnotherThing");
    }

    [MenuItem ("Example/DoOne %a", false, 1)]
    private static void DoOne(){
        Debug.Log("Do One");
    }

    [MenuItem ("Example/DoTwo #c", false, 2)]
    private static void DoTwo(){
        Debug.Log("Do Two");
    }

    [MenuItem ("Example/DoThree &c", false, 13)]
    private static void DoThree(){
        Debug.Log("Do Three");
    }

    // The following string will add a ContextMenu to Camera
    // MenuCommand will give you access to the component value and any userdata
    [MenuItem ("CONTEXT/Camera/DoCameraThing")]
    private static void DoCameraThing(MenuCommand menu){
        Debug.Log(" Do Camera Thing");
    }

    [ContextMenu("ContextSomething")]
    private void ContentSomething(){
        Debug.Log("Context Something");
    }

    [ContextMenuItem ("Reset", "ResetDate")]
    [ContextMenuItem ("Set to Now", "SetDateToNow")]
    public string Date = "";

    public void ResetDate(){
        Date = "";
    }

    public void SetDateToNow(){
        Date = System.DateTime.Now.ToString();
    }
}