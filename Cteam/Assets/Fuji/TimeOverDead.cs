using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeOverDead : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        DateTime TimeLimit = Data.getouttime;
        DateTime NowTime = DateTime.Now;
        switch (TimeLimit.CompareTo(NowTime))
        {
            case -1:
                Debug.Log("DeadScene");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
