using System.Collections;
using UnityEngine;

// Use coroutines in moderation
public class CoroutinesExamples : MonoBehaviour
{

    // Common trick to reduce garbage generation is to cache YieldInstruction
    // Issue in some version that Unity produces garbage in Update frame as
    // it caches the MoveNext value
    // returning null doesn't produce garbage
   IEnumerator TickEverySeconds(){
       var wait = new WaitForSeconds(1f);
       Debug.Log("Ticking Every Second");
       while (true){
           yield return wait;
       }
   }

   IEnumerator TickEveryFrame(){
       Debug.Log("Ticking Every Frame");
       while (true) {
        yield return null;
       }
   }

   IEnumerator TickEveryThreeFrames(){
       Debug.Log("Ticking Every Three Frames");
       while (true) {
        yield return null;
        yield return null;
        yield return null;
       }
   }

   //Ending A coroutine
   // Simple Ending
   IEnumerator TickFiveSeconds() {
       var wait = new WaitForSeconds(1.0f);
       int counter = 1;
       while (counter < 5) {
           Debug.Log("Tick");
           counter ++;
           yield return wait;
       }

       Debug.Log("Done Ticking");
   }

   // To Stop a Corutine from Inside

   IEnumerator ShowExplosions(int health){
       Debug.Log("Show Basic Explosions");
       if (health < 100) yield break;
       Debug.Log("Show Fancy explosion");
   }

   //Stop All Coroutines
   private void OnDisable() {
       StopAllCoroutines();
       // If you started the coroutine by method name string
       // You can stop it like -> StopCoroutine("Method_name")
       // Or you can store the coroutine value returned by the call
       //   -> Coroutine routine = StartCoroutine(MethodName())
       //   -> StopCoroutine(routine)
   }
}
