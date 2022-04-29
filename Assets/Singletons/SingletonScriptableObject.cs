using UnityEngine;
using System;

namespace SingletonScriptableObjectNamespace{
    public class SingletonScriptableObject<T> : BehaviourScriptableObject where T: BehaviourScriptableObject
    {
       public static T _instance;
       public static bool _instantiated;
       public static T Instance{
           get{
                if(_instantiated)
                    return _instance;
                var singletonName = typeof(T).Name;

                var assets = Resources.LoadAll<T>("");
                if(assets.Length > 1)
                    Debug.LogWarning("There should be one");
                
                if(assets.Length == 0){
                    _instance = CreateInstance<T>();
                    Debug.LogError("Couldnt find one thus created in runtime wont be saved");
                }
                else{
                    _instance = assets[0];
                }
                _instantiated = true;
                var baseObject = new GameObject(singletonName);
                baseObject.SetActive(false);
                var proxy = baseObject.AddComponent<BehaviourProxy>();
                proxy.Parent = _instance;
                Behaviour = proxy;
                DontDestroyOnLoad(Behaviour.gameObject);
                proxy.gameObject.SetActive(true);
                return _instance;
           }
       }

       protected static MonoBehaviour Behaviour;

       public static void BuildSingletonInstance(){
           BehaviourScriptableObject i = Instance;
       }

       private void OnDestroy(){
           _instantiated = false;
       }
    }

    public class BehaviourProxy : MonoBehaviour{
        public IBehaviour Parent;

        public void Awake(){
            Parent?.MonoAwake();
        }

        public void Start(){
            Parent?.Start();
        }

        public void Update(){
            Parent?.Update();
        }

        public void FixedUpdate(){
            Parent?.FixedUpdate();
        }
    }

    public interface IBehaviour{
        void MonoAwake();
        void Start();
        void Update();
        void FixedUpdate();
    }

    public class BehaviourScriptableObject : ScriptableObject, IBehaviour{
        public void Awake(){
            ScriptableObjectAwake();
        }

        public virtual void ScriptableObjectAwake(){}

        public virtual void MonoAwake(){}

        public virtual void Start(){}

        public virtual void Update(){}

        public virtual void FixedUpdate(){}
    }
}
