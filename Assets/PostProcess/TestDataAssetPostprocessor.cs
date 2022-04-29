using UnityEditor;
using UnityEngine;

public class TestDataAssetPostprocessor : AssetPostprocessor
{
    const string s_extension = ".test";
    

    // Path starts with Assets
    static bool isFileWeCareAbout(string path){
        return System.IO.Path.GetExtension(path)
            .Equals(s_extension,System.StringComparison.Ordinal);
    }

    static void HandleAddedOrChangedFile(string path){
        string text = System.IO.File.ReadAllText(path);
        // We should check for error here
        TestData.Data newData = JsonUtility.FromJson<TestData.Data>(text);

        string prefabPath = path + ".prefab";
        GameObject exitingPrefab = AssetDatabase.LoadAssetAtPath(prefabPath, typeof(Object)) as GameObject;

        if(!exitingPrefab){
            GameObject newGameObject = new GameObject();
            newGameObject.AddComponent<TestData>();
            PrefabUtility.CreatePrefab(prefabPath, newGameObject, ReplacePrefabOptions.Default);
            GameObject.DestroyImmediate(newGameObject);
            exitingPrefab = AssetDatabase.LoadAssetAtPath(prefabPath, typeof(Object)) as GameObject;     
        }
        TestData testData = exitingPrefab.GetComponent<TestData>();
        if(testData != null){
            testData.data = newData;
            EditorUtility.SetDirty(exitingPrefab);
        }
    }

    static void HandleRemovedFile(string path){
        // Do Something when the file gets removed
    }

    static void OnPostprocessAllAssets(string[] importedAssets, 
    string[] deletedAssets, string[] movedAssets, 
    string[] movedFromAssetPaths){
        foreach (var path in importedAssets)
        {
            if(isFileWeCareAbout(path)){
                HandleAddedOrChangedFile(path);
            }
        }

        foreach(var path in deletedAssets){
            if(isFileWeCareAbout(path)){
                HandleRemovedFile(path);
            }
        }

        // Move prefab if source file gets moved
        for(var ii = 0; ii <movedAssets.Length; ++ii){
            string srcStr = movedFromAssetPaths[ii];
            string dstStr = movedAssets[ii];

            string srcPrefabPath = srcStr + ".prefab";
            string dstPrefabPath = dstStr = ".prefab";
            AssetDatabase.MoveAsset(srcPrefabPath, dstPrefabPath);
        }
    }
}
