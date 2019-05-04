using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InputTimeScript : MonoBehaviour
{
    public InputField inputHour, inputMinutes, inputHour2, inputMinutes2;
    //時間は、左から起きる時間、分、家を出る時間、分
    public static int UpHour,UpMinute,OutHour,OutMinute;
    // Start is called before the first frame update
    void Start()
    {
        inputHour = GameObject.Find("InputHour").GetComponent<InputField>();
        inputMinutes = GameObject.Find("InputMinutes").GetComponent<InputField>();
        inputHour2 = GameObject.Find("InputHour2").GetComponent<InputField>();
        inputMinutes2 = GameObject.Find("InputMinutes2").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputHour()
    {
        Int32.TryParse(inputHour.text, out UpHour);
        var time = Data.getuptime;
        Data.getuptime = new DateTime(time.Year, time.Month, time.Day, UpHour, time.Minute, time.Second);
        PlayerPrefs.SetString("GetUpTime", Data.getuptime.ToBinary().ToString());
        //PlayerPrefs.SetInt("UpHour", UpHour);
        //Debug.Log(UpHour);

        //ここからもデータをstticにあげる
    }
    public void InputMinutes()
    {
        Int32.TryParse(inputMinutes.text, out UpMinute);
        var time = Data.getuptime;
        Data.getuptime = new DateTime(time.Year, time.Month, time.Day, time.Hour, UpMinute, time.Second);
        PlayerPrefs.SetString("GetUpTime", Data.getuptime.ToBinary().ToString());
        //PlayerPrefs.SetInt("UpMinute", UpMinute);
        //Debug.Log(UpMinute);
    }
    public void InputHour2()
    {
        Int32.TryParse(inputHour2.text, out OutHour);
        var time = Data.getouttime;
        Data.getouttime = new DateTime(time.Year, time.Month, time.Day, OutHour, time.Minute, time.Second);
        PlayerPrefs.SetString("GetOutTime", Data.getouttime.ToBinary().ToString());
        //PlayerPrefs.SetInt("OutHour", OutHour);
        //Debug.Log(OutHour);
    }
    public void InputMinutes2()
    {
        Int32.TryParse(inputMinutes2.text, out OutMinute);
        var time = Data.getouttime;
        Data.getouttime = new DateTime(time.Year, time.Month, time.Day, time.Hour, OutMinute, time.Second);
        PlayerPrefs.SetString("GetOutTime", Data.getouttime.ToBinary().ToString());
        //PlayerPrefs.SetInt("OutMinute", OutMinute);
        //Debug.Log(OutMinute);
    }
}
