using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCatch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UniLocalNotification.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("Message", 1, 3);

    }

    void Message()
    {
        UniLocalNotification.Register(1, "あばばばばばばばばばばば", "あえあえあえあえあ");
    }
}
