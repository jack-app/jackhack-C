using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeLocation : MonoBehaviour
{


    public static float longitude
    {
        get;
        private set;
    }

    public static float latitude
    {
        get;
        private set;
    }

    public Text text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Input.location.Start();
        if (Input.location.lastData.latitude != 0 && Input.location.lastData.longitude != 0)
        {
            latitude = Input.location.lastData.latitude;
            longitude = Input.location.lastData.latitude;

            text.text = "位置情報の取得が\n終わりました";
        print(Input.location.lastData.latitude+":"+Input.location.lastData.longitude);
            Invoke("Return", 2);
        }




    }

    private void Return()
    {
        SceneManager.LoadScene("MainScene");
    }

}
