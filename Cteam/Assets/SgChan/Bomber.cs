using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour
{
    public bool success
    {
        get;
        private set;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.location.Start();
        if (Input.location.status == LocationServiceStatus.Running&&Input.location.lastData.latitude!=0&&Input.location.lastData.longitude!=0)
        {
            var homelatitude = HomeLocation.latitude;
            var homelongitude = HomeLocation.longitude;
            var latitude = Input.location.lastData.latitude;
            var longitude = Input.location.lastData.longitude;
            var latitudelength = (latitude - homelatitude)*10000;
            var longitudelength = (longitude - homelongitude)*10000;
           print(latitudelength + ":" + longitudelength );
           // print(latitude + ":" + longitude+":"+homelatitude+":"+homelongitude);
        }

    }
}
