using UnityEngine;
using System;
using UnityEditor;
public enum Gender{
    Male,
    Female,
    Other
}

[Serializable]
public class UserInfo{
    public string name;
    public int age;
    public Gender gender;
}

public class PropertyDrawerExample : MonoBehaviour{
    public UserInfo userInfo;
}

[CustomPropertyDrawer (typeof (UserInfo))]
public class UserInfoDrawer : PropertyDrawer{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight * 4 + 6;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        EditorGUI.BeginProperty(position, label, property);
        EditorGUI.LabelField(position, label);

        var nameRect = new Rect(position.position.x, position.position.y+18,position.width,16);
        var ageRect = new Rect(position.position.x, position.position.y+36,position.width,16);
        var genderRect = new Rect(position.position.x, position.position.y+54,position.width,16);

        EditorGUI.indentLevel++;
        
        // Should be cacheg generally
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"));
        EditorGUI.PropertyField(ageRect, property.FindPropertyRelative("age"));
        EditorGUI.PropertyField(genderRect, property.FindPropertyRelative("gender"));

        EditorGUI.indentLevel--;
        EditorGUI.EndProperty();
    }
}