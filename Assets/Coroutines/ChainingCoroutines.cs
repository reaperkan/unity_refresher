using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// -> Start() can be a coroutine
// -> OnBecameVisible() can be a coroutine, called when obj becomes visible on camera
// -> OnLevelWasLoaded() can be a coroutine
public class ChainingCoroutines : MonoBehaviour
{
    IEnumerator BeginRace(){
        yield return StartCoroutine(PrepareRace());
        yield return StartCoroutine(CountDown());
        yield return StartCoroutine(StartRace());
    }

    IEnumerator BeginRace_2(){
        IEnumerator[] routines = new IEnumerator[] { PrepareRace(), CountDown(), StartRace() };
        yield return StartCoroutine(ChainedCoroutines(routines));
        // Use of params in argument in ChainedCoroutines allows us to send 'n' number of arguments
        // So we can do this as well
        // -> yield return StartCoroutine(ChainedCoroutines(PrepareRace(),CountDown(),StartRace()));
    }

    IEnumerator ChainedCoroutines(params IEnumerator[] routines){
        foreach(var item in routines){
            while(item.MoveNext()){
                yield return item.Current;
            }
        }
        // To breakout of the coroutine
        yield break;
    }

    IEnumerator PrepareRace(){
        Debug.Log("Preparing Race");
        yield return null;
    }

    IEnumerator CountDown(){
        Debug.Log("Counting Down");
        yield return null;
    }

    IEnumerator StartRace(){
        Debug.Log("Start Race");
        yield return null;
    }
}
