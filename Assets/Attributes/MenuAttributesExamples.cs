using UnityEngine;


// Will add a component inside component dropdown
[AddComponentMenu("Examples/Attribute Example")]
public class MenuAttributesExamples : MonoBehaviour
{
    // Adds a special right click action for the variable which wwill then run the 
    // 2nd argument that is the function name
    [ContextMenuItem("My Field Action", "MyFieldContextAction")]
    public string myString;

    private void MyFieldContextAction(){
        Debug.Log("Test");
    }


    // Adds a custom action for the component 
    // Selecting this will run the function
    [ContextMenu("My Action")]
    private void MyContextMenuAction(){
        Debug.Log("Test 2");
    }
}
