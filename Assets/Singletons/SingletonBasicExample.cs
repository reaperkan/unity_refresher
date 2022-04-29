using UnityEngine;

public class SingletonBasicExample : MonoBehaviour
{
    public static SingletonBasicExample Instance{
        get;
        private set;
    }


    // Due to RuntimeInitializeOnLoadMethod attribute this static method 
    // gets called before all the other Monobehaviors in the scene
    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad(){
        var instance = FindObjectOfType<SingletonBasicExample>();

        if(instance == null){
            // When this AddComponent is executed it prompts to call the Awake method
            // on this component 
            instance = new GameObject("SingletonBasicExample").AddComponent<SingletonBasicExample>();
        }

        DontDestroyOnLoad(instance);

        Instance = instance;
    }

    void Awake(){
        Debug.Log("SingletonBasicExample Awake",this);
    }
}

public class SingletonBasic : MonoBehaviour{
    private static SingletonBasic _instance;

    void Awake(){
        if(_instance == null){
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }else{
            Destroy(this);
        }
    }
}
