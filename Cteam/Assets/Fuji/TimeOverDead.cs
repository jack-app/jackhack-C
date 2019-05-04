using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class TimeOverDead : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //1秒に一回時間を確認する
        InvokeRepeating("TimeCheck", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TimeCheck()
    {
        DateTime TimeLimit = Data.getouttime;
        DateTime NowTime = DateTime.Now;

        switch (TimeLimit.CompareTo(NowTime))
        {
            case -1:
                SceneManager.LoadScene("Dead"); 
                break;
        }
    }
}
