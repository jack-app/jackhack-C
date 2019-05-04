using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TommorowScript : MonoBehaviour
{
    Button btn;
    Color btnColor = Color.green;
    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("TommorowButton").GetComponent<Button>();
        if (Data.alarm)
        {
            btn.image.color = btnColor;
            btn.GetComponentInChildren<Text>().text = "アラーム設定中";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Data.alarm = !Data.alarm;
        if (Data.alarm)
        {
            btn.image.color = btnColor;
            btn.GetComponentInChildren<Text>().text = "アラーム設定中";
            var getup = Data.getuptime;
            var getout = Data.getouttime;
            var now = System.DateTime.Now;

            Data.getuptime = new System.DateTime(now.Year, now.Month, now.Day, getup.Hour, getup.Minute, getup.Second);
            Data.getouttime = new System.DateTime(now.Year, now.Month, now.Day, getout.Hour, getout.Minute, getout.Second);
            if (now.Hour >= getout.Hour)
            {
                Data.getuptime.AddDays(1);
                Data.getouttime.AddDays(1);

            }
        }
        else
        {
            btn.image.color = Color.white;
            btn.GetComponentInChildren<Text>().text = "アラーム解除中";
        }
        //Debug.Log(Data.alarm);
        PlayerPrefs.SetString("GetUpTime", Data.getuptime.ToBinary().ToString());
        PlayerPrefs.SetString("GetOutTime", Data.getouttime.ToBinary().ToString());
        PlayerPrefs.SetInt("Alarm", Data.alarm ? 1 : 0);
    }
}
