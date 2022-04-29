using UnityEngine;

public class TestData : MonoBehaviour
{
    [System.Serializable]
    public class Data{
        public int someValue = 0;
        public float someOtherValue = 0.0f;

        public bool someBoolValue = false;
        public string someStringValue = "";
    }

    public Data data = new Data();
}
