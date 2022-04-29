using UnityEditor;
using UnityEngine;


// Loading From Resources Folder, the folder can be in any place in 
// the hierarchy

// All the resources folders are merged together
// Dont add unnecessary objects in the resources folder


// Extension is not given for Resources
public class PrefabExample : MonoBehaviour
{
    public GameObject prefab;

    public static GameObject prefab_2;

    [InitializeOnLoadMethod]
    static void OnLoad(){
        prefab_2 = AssetDatabase.LoadAssetAtPath<GameObject>
            ("Assets/Test/PrefabsAndResources/Resources/prefab.prefab");
        Debug.Log(prefab_2);
    }

    void Start(){
        prefab = Resources.Load("prefab") as GameObject;
        // Unload all unused assets
        //Resources.UnloadUnusedAssets();

        // Unload specific resource
        // Resources.UnloadAsset(prefab);
    }
}
