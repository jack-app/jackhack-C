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

    //次にアラームが鳴る日
    public static int alarmdate;
    


    // Start is called before the first frame update
    void Start()
    {
        homelatitude = PlayerPrefs.GetFloat("HomeLatitude");
        homelongitude = PlayerPrefs.GetFloat("HomeLongitude");

        string defalt= new DateTime(0, 0, 0, 0, 0, 0, DateTimeKind.Local).ToBinary().ToString();//保存していたデータが存在しない時用のデフォルト値
        getuptime = System.DateTime.FromBinary(System.Convert.ToInt64(PlayerPrefs.GetString("GetUpTime", defalt)));
        getouttime = System.DateTime.FromBinary(System.Convert.ToInt64(PlayerPrefs.GetString("GetOutTime", defalt)));
        alarmdate = PlayerPrefs.GetInt("AlarmDate");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
