using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

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
        inputHour.text= Data.getuptime.Hour.ToString();
        inputMinutes.text = Data.getuptime.Minute.ToString();
        inputHour2.text = Data.getouttime.Hour.ToString();
        inputMinutes2.text = Data.getouttime.Minute.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputHour()
    {
        Int32.TryParse(inputHour.text, out UpHour);
        if (0 <= UpHour && UpHour <= 23)
        {
            var time = Data.getuptime;
            Data.getuptime = new DateTime(time.Year, time.Month, time.Day, UpHour, time.Minute, time.Second);
            PlayerPrefs.SetString("GetUpTime", Data.getuptime.ToBinary().ToString());
            //PlayerPrefs.SetInt("UpHour", UpHour);
            //Debug.Log(UpHour);

            //ここからもデータをstticにあげる
        }
        else
        {
            SceneManager.LoadScene("SettingScene");
        }
    }
    public void InputMinutes()
    {
        Int32.TryParse(inputMinutes.text, out UpMinute);
        if (0 <= UpMinute && UpMinute <= 59) {
            var time = Data.getuptime;
            Data.getuptime = new DateTime(time.Year, time.Month, time.Day, time.Hour, UpMinute, time.Second);
            PlayerPrefs.SetString("GetUpTime", Data.getuptime.ToBinary().ToString());
            //PlayerPrefs.SetInt("UpMinute", UpMinute);
            //Debug.Log(UpMinute);
        }
        else
        {
            SceneManager.LoadScene("SettingScene");
        }
    }
    public void InputHour2()
    {
        Int32.TryParse(inputHour2.text, out OutHour);
        if (0 <= OutHour && OutHour <= 23)
        {
            var time = Data.getouttime;
            Data.getouttime = new DateTime(time.Year, time.Month, time.Day, OutHour, time.Minute, time.Second);
            PlayerPrefs.SetString("GetOutTime", Data.getouttime.ToBinary().ToString()); 
            //PlayerPrefs.SetInt("OutHour", OutHour);
            //Debug.Log(OutHour);
        }
        else
        {
            SceneManager.LoadScene("SettingScene");
        }
    }
    public void InputMinutes2()
    {
        Int32.TryParse(inputMinutes2.text, out OutMinute);
        if (0 <= OutMinute && OutMinute <= 59)
        {
            var time = Data.getouttime;
            Data.getouttime = new DateTime(time.Year, time.Month, time.Day, time.Hour, OutMinute, time.Second);
            PlayerPrefs.SetString("GetOutTime", Data.getouttime.ToBinary().ToString());
            //PlayerPrefs.SetInt("OutMinute", OutMinute);
            //Debug.Log(OutMinute);
        }
        else
        {
            SceneManager.LoadScene("SettingScene");
        }
    }
}
