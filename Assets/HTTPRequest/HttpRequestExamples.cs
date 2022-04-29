using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HttpRequestExamples : MonoBehaviour
{
    // Basic Get
    IEnumerator Start(){
        WWW www = new WWW("http://www.google.com");
        yield return www;
        Debug.Log(www.text);
    }


    // Basic Post
    void Login(string id, string pwd){
        WWWForm dataParameters = new WWWForm();
        dataParameters.AddField("username", id);
        dataParameters.AddField("password", pwd);
        WWW www = new WWW("http//www.google.com/account/login",dataParameters);
        StartCoroutine("Postdata",www);
    }

    IEnumerator Postdata(WWW www){
        yield return www;
    }
}
