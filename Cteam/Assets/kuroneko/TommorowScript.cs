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
        }
        else
        {
            btn.image.color = Color.white;
            btn.GetComponentInChildren<Text>().text = "アラーム設定";
        }
        //Debug.Log(Data.alarm);
        PlayerPrefs.SetInt("Alarm", Data.alarm ? 1 : 0);
    }
}
