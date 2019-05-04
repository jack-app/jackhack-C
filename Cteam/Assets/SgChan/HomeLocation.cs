using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeLocation : MonoBehaviour
{



    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Failed", 6);
    }

    // Update is called once per frame
    void Update()
    {
        Input.location.Start();
        if (Input.location.lastData.latitude != 0 && Input.location.lastData.longitude != 0)
        {
            var latitude = Input.location.lastData.latitude;
            Data.homelatitude = latitude;
            PlayerPrefs.SetFloat("HomeLatitude", latitude);
            var longitude = Input.location.lastData.longitude;
            Data.homelongitude = longitude;
            PlayerPrefs.SetFloat("HomeLongitude", longitude);


            text.text = "位置情報の取得が\n終わりました";
        print(Input.location.lastData.latitude+":"+Input.location.lastData.longitude);
            Invoke("Return", 2);
        }




    }

    private void Return()
    {
        SceneManager.LoadScene("SettingScene");
    }

    void Failed()
    {
        text.text = "情報を取得できませんでした";
        Invoke("Return", 2);
    }
}
