using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class BombTiedScene : MonoBehaviour
{

    DateTime Getup;
    DateTime Departure;

    // Start is called before the first frame update
    void Start()
    {



        
           
            TimeCheck();
            //1秒に1回時間を確認
            InvokeRepeating("TimeCheck", 1, 1);
        



    }

    // Update is called once per frame
    void Update()
    {

    }

    void TimeCheck()
    {
        Getup = Data.getuptime;
        Departure = Data.getouttime;
        if (Data.alarm)
        {
            print(Departure);
            DateTime Now = DateTime.Now;
            //時間を過ぎてたら
            if (Now > Departure)
            {
                SceneManager.LoadScene("Dead");
            }
            else
            {
                if (Now > Getup)
                {
                    print("a");
                    SceneManager.LoadScene("BombTiedScene");
                }
            }
        }
       
    }
}
