using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimitText : MonoBehaviour
{
    public Text timelimit;
    System.DateTime bombtime;
    // Start is called before the first frame update
    void Start()
    {
        bombtime = Data.getouttime;
    }

    // Update is called once per frame
    void Update()
    {
        var limit = System.DateTime.Now - bombtime;
        timelimit.text = "爆破まで" + limit.Hours + ":" + limit.Minutes + ":" + limit.Seconds;
    }
}
