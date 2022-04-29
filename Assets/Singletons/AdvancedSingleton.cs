using UnityEngine;

[DisallowMultipleComponent]
public abstract class AdvancedSingleton<T> : MonoBehaviour where T : AdvancedSingleton<T>{
    private static volatile T instance;

    private static object _lock = new object();
    public static bool FindInactive = true;

    public static bool Persist;

    public static bool DestroyOthers = true;

    private static bool instantiated;

    private static bool applicationIsQuitting;

    public static bool Lazy;

    public static T Instance{
        get{
            if(applicationIsQuitting){
                return null;
            }
            lock(_lock){
                if(!instantiated){
                    Object[] objects;
                    if(FindInactive){
                        objects = Resources.FindObjectsOfTypeAll(typeof(T));
                    }else{
                        objects = FindObjectsOfType(typeof(T));
                    }

                    if(objects == null || objects.Length < 1){
                        GameObject singleton = new GameObject();
                        singleton.name = string.Format("{0} [Singleton]",typeof(T));
                        Instance = singleton.AddComponent<T>();
                    }else if(objects.Length >= 1){
                        Instance = objects[0] as T;
                        if(objects.Length > 1){
                            if(DestroyOthers){
                                for(int i =1; i< objects.Length; i++){
                                    Destroy(objects[i]);
                                }
                            }
                        }
                        return instance;
                    }
                }
                return instance;
            }
        }
        protected set{
            instance = value;
            instantiated = true;
            instance.AwakeSingleton();
            if(Persist){
                DontDestroyOnLoad(instance.gameObject);
            }
        }
    }

    private void Awake(){
        if(Lazy)
            return;
        lock(_lock){
            if(!instantiated){
                Instance = this as T;
            }else if(DestroyOthers && Instance.GetInstanceID() != GetInstanceID()){
                Destroy(this);
            }
        }
    }

    protected virtual void AwakeSingleton(){}

    protected virtual void OnDestroy(){
        applicationIsQuitting = true;
        instantiated = false;
    }
}