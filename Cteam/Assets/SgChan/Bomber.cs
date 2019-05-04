using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomber : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GPSCheck",1,1);
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void GPSCheck()
    {
        Input.location.Start();
        if (Input.location.status == LocationServiceStatus.Running && Input.location.lastData.latitude != 0 && Input.location.lastData.longitude != 0)
        {
            var homelatitude = Data.homelatitude;
            var homelongitude = Data.homelongitude;
            var latitude = Input.location.lastData.latitude;
            var longitude = Input.location.lastData.longitude;
            var latitudelength = (latitude - homelatitude) * 10000;
            var longitudelength = (longitude - homelongitude) * 10000;
            print(latitudelength + ":" + longitudelength);

            var direction = latitude * latitude + longitude * longitude;

            // print(latitude + ":" + longitude+":"+homelatitude+":"+homelongitude);
            if (direction > 20)
            {
                
                SceneManager.LoadScene("MainScene");
            }
        }
    }

}
