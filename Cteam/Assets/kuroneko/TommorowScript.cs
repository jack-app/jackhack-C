using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TommorowScript : MonoBehaviour
{
    Button btn;
    
    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("TommorowButton").GetComponent<Button>();
        if (Data.alarm)
            btn.image.color = Color.blue;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Data.alarm = !Data.alarm;
        if (Data.alarm)
            btn.image.color = Color.blue;
        else
            btn.image.color = Color.white;
        Debug.Log(Data.alarm);
        PlayerPrefs.SetInt("Alarm", Data.alarm ? 1 : 0);
    }
}
