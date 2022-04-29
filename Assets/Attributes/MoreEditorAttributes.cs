using UnityEngine;
using UnityEditor;

// So that multi editing is allowed in the component
[CanEditMultipleObjects]
public class MoreEditorAttributes : MonoBehaviour
{
    public int myInt;

    private static string prefsText="";

    // Will create a my prefs menu in Preferences

    [PreferenceItem("My Prefs")]
    public static void PreferencesGUI(){
        prefsText=EditorGUILayout.TextField("Prefs Text", prefsText);
    }


    //Adds an a new menu item in the editor
    [MenuItem("Attributes/Foo")]
    private static void Foo(){
        Debug.Log("Called MoreEditorAttributesFoo");
    }

    // For validation of that menuitem to be displayed or not
    [MenuItem("Attributes/Foo", true)]
    private static bool FooValidate(){
        return false;
    }

    // Will draw custom gizmo for your components 
    // They will be drawn in the scene based on when you decide to draw gizmotype
    // [DrawGizmo(GizmoType.Selected)]
    // private static void DoGizmo(MenuAttributesExamples obj, GizmoType type){

    // }
}

// For creating a custom editor for your component 
// [CustomEditor(typeof(ExampleAds))]
// public class CustomEditorClass : Editor{

// }


// For creating a custom property drawer for your custom data types in 
// in your component 
// [CustomPropertyDrawer(typeof(ExampleAds))]
// public class CustomPropertyDrawerClass : PropertyDrawer{

// }