using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetOutScript : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("GetOutText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string minute;
        if (Data.getouttime.Minute < 10)
        {
            minute = "0"+Data.getouttime.Minute;
        }
        else
        {
            minute= ""+ Data.getouttime.Minute;
        }
        text.text = "出発時刻は " + Data.getouttime.Hour + ":" + minute + " です";
    }
}
