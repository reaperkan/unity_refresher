// partial classes tells the compiler to look for  the rest of the
// implementation elsewhere

// if partial methods are not implemented compiler omits the call
#if UNITY_IPHONE
    public partial class PartialClassExample : MonoBehaviour{
        
        void OnEnable(){
            Debug.Log("Enabled in Iphone");
        }

        partial void PlatformSpecificMethod(){
            Debug.Log("Something in here");
        }
    }
#endif

#if UNITY_ANDROID
    public partial class PartialClassExample : MonoBehaviour{

        void OnEnable(){
            Debug.Log(" I am in Android");
        }

        partial void PlatformSpecificMethod(){
            Debug.Log("Android Internal");
        }
    }
#endif