using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagsExample : MonoBehaviour
{
    public GameObject playerObj;

    static string playerTag = "Player";
    
    void Start()
    {
        playerObj.tag = playerTag;

        // This comparison will generate garbage due to the string
        if (playerObj.tag == "Player"){}

        // This wont generate any garbage as they are heap allocated free method
        if(playerObj.CompareTag("Player")){}
        // its always better to maintain a static class containing all the tags and then compare
        // Also possible to store the tags in an enum and then use the toString() method to get the string

    }


    void Update()
    {
        
    }
}
