using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Data : MonoBehaviour
{
    //家の緯度経度
    public static float homelatitude;
    public static float homelongitude;
    //起きる時間、分
    public static DateTime getuptime;
    public static DateTime getouttime;

    //家を出る時間、分
    public static int goouthour;
    public static int gooutminute;
    //次にアラームが鳴る日
    public static int alarmdate;
    


    // Start is called before the first frame update
    void Start()
    {
        homelatitude = PlayerPrefs.GetFloat("HomeLatitude");
        homelongitude = PlayerPrefs.GetFloat("HomeLongitude");
        getuphour = PlayerPrefs.GetInt("UpHour");
        getupminute = PlayerPrefs.GetInt("UpMinute");
        goouthour = PlayerPrefs.GetInt("OutHour");
        gooutminute = PlayerPrefs.GetInt("OutMinute");
        alarmdate = PlayerPrefs.GetInt("AlarmDate");
        print(getuphour);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
