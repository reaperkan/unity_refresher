using UnityEngine;
using UnityEditor;
using System.Linq;
public class CustomEditorWindowExample : EditorWindow
{
    private AnimationClip _animationClip;
    private SerializedObject _serializedClip;
    private SerializedProperty _serializedEvents;

    private string _text = "Hello World";

    [MenuItem ("Window/Custom Window")]
    static void Init(){
        // Get existing window , if none create one
        CustomEditorWindowExample window = (CustomEditorWindowExample) EditorWindow.GetWindow(typeof(CustomEditorWindowExample));
        window.Show();
    }

    private void OnGUI() {
        GUILayout.Label("This is a custom editor window", EditorStyles.boldLabel);
        _text = EditorGUILayout.TextField("Text Field", _text);

        if (_animationClip == null || _serializedClip == null || _serializedEvents == null)
            return;
        
        GUILayout.Label(_animationClip.name, EditorStyles.boldLabel);

        for(var i = 0; i < _serializedEvents.arraySize; i++){
            EditorGUILayout.BeginVertical();

            EditorGUILayout.LabelField("Event: "+_serializedEvents.GetArrayElementAtIndex(i).FindPropertyRelative("functionName").stringValue,
                EditorStyles.boldLabel);

            EditorGUILayout.PropertyField(_serializedEvents.GetArrayElementAtIndex(i).FindPropertyRelative("time"),true,GUILayout.ExpandWidth(true));
            EditorGUILayout.PropertyField(_serializedEvents.GetArrayElementAtIndex(i).FindPropertyRelative("functionName"),true,GUILayout.ExpandWidth(true));
            EditorGUILayout.PropertyField(_serializedEvents.GetArrayElementAtIndex(i).FindPropertyRelative("floatParameter"),true,GUILayout.ExpandWidth(true));
            EditorGUILayout.PropertyField(_serializedEvents.GetArrayElementAtIndex(i).FindPropertyRelative("intParameter"),true,GUILayout.ExpandWidth(true));
            EditorGUILayout.PropertyField(_serializedEvents.GetArrayElementAtIndex(i).FindPropertyRelative("objectReferenceParameter"),true,GUILayout.ExpandWidth(true));
            EditorGUILayout.Separator();
            EditorGUILayout.EndVertical();
        }

        _serializedClip.ApplyModifiedProperties();
    }

    // The function is triggered when user selects something or window refreshes
    private void OnSelectionChange() {
        _animationClip = Selection.GetFiltered(typeof (AnimationClip),SelectionMode.Assets).FirstOrDefault() as AnimationClip;
        if (_animationClip == null)
            return;
        
        _serializedClip = new SerializedObject(_animationClip);
        _serializedEvents = _serializedClip.FindProperty("m_Events");
        Repaint();
    }
}
