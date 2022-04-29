using UnityEngine;
using UnityEngine.Profiling;
public class ProfilerclassExample : MonoBehaviour
{
    void SomeFunction(){
        // This will create a separate entry into the profiler window
        // which will help you to debug
        Profiler.BeginSample("Indentifier");
        // Some Calls
        Profiler.EndSample();
    }
}
