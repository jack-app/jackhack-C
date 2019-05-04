using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Data : MonoBehaviour
{

    public  static bool alarm;
    //家の緯度経度
    public static float homelatitude;
    public static float homelongitude;
    //起きる時間、分
    public static DateTime getuptime;

    //家を出る時間、分
    public static DateTime getouttime;

    


    // Start is called before the first frame update
    void Start()
    {
        homelatitude = PlayerPrefs.GetFloat("HomeLatitude");
        homelongitude = PlayerPrefs.GetFloat("HomeLongitude");

        string defalt= new DateTime(2019, 1, 1, 0, 0, 0, DateTimeKind.Local).ToBinary().ToString();//保存していたデータが存在しない時用のデフォルト値
        getuptime = System.DateTime.FromBinary(System.Convert.ToInt64(PlayerPrefs.GetString("GetUpTime", defalt)));
        getouttime = System.DateTime.FromBinary(System.Convert.ToInt64(PlayerPrefs.GetString("GetOutTime", defalt)));

        alarm = 1 == PlayerPrefs.GetInt("Alarm");
        print(getouttime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
