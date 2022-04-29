using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class InspectorExample : MonoBehaviour
{
    public int level;
    public float baseDamage;

    public float damageBonus{
        get{
            return level * 0.5f;
        }
    }

    public float actualDamage{
        get{
            return baseDamage + damageBonus;
        }
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof (InspectorExample))]
public class CustomInspector : Editor{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var ie = (InspectorExample) target;

        EditorGUILayout.LabelField("Damage Bonus", ie.damageBonus.ToString());
        EditorGUILayout.LabelField("Actual Damage", ie.actualDamage.ToString());
    }
}
#endif