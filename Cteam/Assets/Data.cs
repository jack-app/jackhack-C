using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Data : MonoBehaviour
{
    public static int getupdays;

    public  static bool alarm;
    //家の緯度経度
    public static float homelatitude;
    public static float homelongitude;
    //起きる時間、分
    public static DateTime getuptime;

    //家を出る時間、分
    public static DateTime getouttime;

    public static string dogname;
    


    // Start is called before the first frame update
    void Awake()
    {
        homelatitude = PlayerPrefs.GetFloat("HomeLatitude");
        homelongitude = PlayerPrefs.GetFloat("HomeLongitude");
        getupdays = PlayerPrefs.GetInt("GetUpDays", 0);
        dogname = PlayerPrefs.GetString("DogName");
        string defalt= new DateTime(3000, 1, 1, 0, 0, 59, DateTimeKind.Local).ToBinary().ToString();//保存していたデータが存在しない時用のデフォルト値
        getuptime = System.DateTime.FromBinary(System.Convert.ToInt64(PlayerPrefs.GetString("GetUpTime", defalt)));
        getouttime = System.DateTime.FromBinary(System.Convert.ToInt64(PlayerPrefs.GetString("GetOutTime", defalt)));

        alarm = 1 == PlayerPrefs.GetInt("Alarm");
        print(alarm);
        print(getuptime);
        print(getouttime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
