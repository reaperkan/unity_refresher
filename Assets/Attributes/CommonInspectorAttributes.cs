using UnityEngine;


// Wont allow multiple of the same script component
[DisallowMultipleComponent]
[RequireComponent(typeof(Camera))]
public class CommonInspectorAttributes : MonoBehaviour
{
   [Header("My variables")]
   public string MyString;

   [HideInInspector]
   public string MyHiddenString;

   [Multiline(5)]
   public string MyMultilineString;

   [TextArea (1,5)]
   public string MyTextArea;


   [Space(15)]
   public int myInt;

   [Range (2.5f, 15f)]
   public float myFloat;

   [Tooltip ("This is a tip")]
   public double MyDouble;

   [SerializeField]
   private double myHiddenDouble;
}
