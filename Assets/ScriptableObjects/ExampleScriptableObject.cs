using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// pay attention when adding prefabs with scriptable objects
// to AssetBundles , Unity creates duplocates of them before
// adding them to assetbundles

// when loading GO from assetbundles it may be necessary to reinject
// scriptable object assets , dependency injection

// ScriptableObjects are about to asset files and not to any scenes or gameobject
[CreateAssetMenu(menuName = "TestSO/Example/MyObject")]
public class ExampleScriptableObject : ScriptableObject
{
    [SerializeField]
    private int mySerializedNumber;

    private int helloWorld = 0;

    public void HelloWorld(){
        helloWorld++;
        Debug.LogFormat("Number is {0}.",mySerializedNumber);
        Debug.LogFormat("Hello World is {0}.",helloWorld);
    }
}

//Scriptable objects are serialized in editor even in playmod so the values
// are not resetted , if the variable is marked with [SerializeField] or
// is public variable

// Make them read only 
// public int MySerializedValue
// { 
//    get {return mySerializedValue}
//}

// Or Make private variables and expose getter and setters
// this will prevent it from saving the values from runtime
// public int MySerializedValue
// { 
//    get {return mySerializedValue; }
//    set {mySerializedValue = value;}
//  }
