using UnityEngine;
using System.Collections;
public class UploadZip : MonoBehaviour
{
    string mainUrl = "";
    string saveLocation = "ftp:///home/xxx/x.zip";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrepareFile());
    }

    IEnumerator PrepareFile(){
        WWW loadTheZip = new WWW(saveLocation);
        yield return loadTheZip;
        PrepareStepTwo(loadTheZip);
    }

    void PrepareStepTwo(WWW post){
        StartCoroutine(UploadFile(post));
    }

    IEnumerator UploadFile(WWW post){
        WWWForm form = new WWWForm();
        form.AddBinaryData("myTestFile.zip",post.bytes,"myFile.zip","application/zip");

        WWW postZip = new WWW(mainUrl, form);
        yield return postZip;
    }
}
