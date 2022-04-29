using UnityEngine;

public class VectorExample : MonoBehaviour
{
   
   Vector3 startPos = new Vector3(0,0,0);
   Vector3 endPos = new Vector3(10,10,10);
   float lerpFraction = 0;
   void Start(){     
        // Vector3.zero == (0,0,0)
        // Vector3.one == (1,1,1)
        // Vector3.left == (-1,0,0)
        // Vector3.right == (1,0,0)
        // Vector3.down == (0,-1,0)
        // Vector3.up == (0,1,0)
        // Vector3.back == (0,0,-1)
        // Vector3.forward == (0,0,1)
   }

   void Lerp(){
      // Will add 1 to the lerp fraction every second
      lerpFraction += Time.deltaTime * .25f;
      // Will Move from point A to point B based on the lerp fraction
      // 0 is point A , 1 is point B , 0.5f is the midpoint between A and B
      // The movement vector will be clamped between A and B
      transform.position = Vector3.Lerp(startPos, endPos, lerpFraction);
      // Using LerpUnclamed can move the vector between the end pos
      transform.position = Vector3.LerpUnclamped(startPos, endPos, lerpFraction);
   }

   void MoveTowards(){
      float speed = 5;
      // It is same as lerp but it moves by distance
      // This is the amount of distance that will be added to the current position
      // Every Update all
      var distance = speed * Time.deltaTime;
      // We can provide a negative value to move the object away from target position
      transform.position = Vector3.MoveTowards(startPos, endPos, distance);
   }

   void SmoothDamp(){
      Vector3 velocity = Vector3.forward;
      float smoothTime = 1.0f;
      float maxSpeed = 10;
      // SmoothDamp is a variant of MoveTowards with built in smoothing
      // Most commonly used for camera following
      // The velocity value is modified by the function everytime it gets called
      // Smooth time  is the approxmiately time it will take to reach the target
      // Max speed allows you to clamp the maximum speed
      // We are passing 0 in place of Time.deltaTime so that the function see that no time has been passed since last 
      // call and it wont produce any movement, default is Time.deltaTime if we dont pass any values
      transform.position = Vector3.SmoothDamp(startPos,endPos,ref velocity, smoothTime, maxSpeed, 0);
   }
}
