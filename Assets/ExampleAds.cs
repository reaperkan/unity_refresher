using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;
public class ExampleAds : MonoBehaviour
{

    #if !UNITY_ADS
    public string gameId;
    public bool enableTestMode =true;
    #endif


    void InitializeAds()
    {
        #if !UNITY_ADS
        if(Advertisement.isSupported){
            Advertisement.Initialize(gameId, enableTestMode);
        }
        #endif
    }


    void ShowAds()
    {
        if(Advertisement.isInitialized  || Advertisement.IsReady()){
            Advertisement.Show();
        }
    }

    void Awake(){
        InitializeAds();
    }

    void Start(){
        StartCoroutine(Ads());
    }

    IEnumerator Ads(){
        yield return new WaitForSeconds(3.0f);
        ShowAds();
    }
}
