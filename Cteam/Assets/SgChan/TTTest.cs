﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TTTest : MonoBehaviour
{
    public int judgedistance;
    public Text directiontext;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("GPSCheck", 1, 1);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.location.status != LocationServiceStatus.Running)
        {
            Input.location.Start();

        }
        GPSCheck();
    }

    void GPSCheck()
    {

        print(Input.location.status);

        if (Input.location.status == LocationServiceStatus.Running && Input.location.lastData.latitude != 0 && Input.location.lastData.longitude != 0)
        {
            var homelatitude = Data.homelatitude;
            var homelongitude = Data.homelongitude;
            var latitude = Input.location.lastData.latitude;
            var longitude = Input.location.lastData.longitude;
            var latitudelength = (latitude - homelatitude) * 10000;
            var longitudelength = (longitude - homelongitude) * 10000;
            //print(latitudelength + ":" + longitudelength);

            var direction = latitudelength * latitudelength + longitudelength * longitudelength;
            //print(direction);
            //print("latitude" + latitude + ":" + "longitude" + longitude + ":" + "homelatitude" + homelatitude + ":" + "homelongitude" + homelongitude);

            directiontext.text = latitude + ":" + longitude;

        }
    }
}
