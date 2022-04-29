using System.Net;
using System.Text;

public class TestCommunication
{
    public string SendDataToServer(string url, string username, string password){
        WebClient client = new WebClient();
        
        var loginData = new System.Collections.Specialized.NameValueCollection();
        loginData.Add("Username", username);
        loginData.Add("Password", password);

        //Make the HTTP request
        byte[] opBytes = client.UploadValues(url,"POST",loginData);

        //Encode the value to proper string from bytes
        string opResponse = Encoding.UTF8.GetString(opBytes);

        return opResponse;
    }
}
