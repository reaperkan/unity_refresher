using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonBaseClass<T> : MonoBehaviour
{
    private static Dictionary<Type, object> _singletons = new Dictionary<Type, object>();

    public static T Instance{
        get{
            return (T)_singletons[typeof(T)];
        }
    }

    void OnEnable(){
        if(_singletons.ContainsKey(GetType())){
            Destroy(this);
        }else{
            _singletons.Add(GetType(), this);
            DontDestroyOnLoad(this);
        }
    }
}
