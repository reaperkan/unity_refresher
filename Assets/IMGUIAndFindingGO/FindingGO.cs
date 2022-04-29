using UnityEngine;

public class FindingGO : MonoBehaviour
{
    void Searches(){
        //- Slow as the number of gameobjects increase in scene
        var go = GameObject.Find("NameOfGO");
        // Possible to search single go and group of gos
        // Fast and efficient as Unity keeps a list of tag go
        var go_2 = GameObject.FindGameObjectWithTag("Tag");
        // Slow as the number of gameobjects increase in scene
        var go_3 = GameObject.FindObjectOfType<Transform>().gameObject;
        // Well defined scope but to search child and parent only
        GetComponent<Transform>().Find("NameOfTheChild");
    }

    void OnGUI(){
        GUILayout.Label(" Simple Label ");

        if(GUILayout.Button("Click me")){
            GUILayout.TextArea("This is a \n multiline comment");
        }
    }
}
