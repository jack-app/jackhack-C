using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetUpScript : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("GetUpText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string minute;
        if (Data.getuptime.Minute < 10)
        {
            minute = "0" + Data.getuptime.Minute;
        }
        else
        {
            minute = "" + Data.getuptime.Minute;
        }
        text.text = "起床時刻は " + Data.getuptime.Hour + ":" + minute + " です";
    }
}
