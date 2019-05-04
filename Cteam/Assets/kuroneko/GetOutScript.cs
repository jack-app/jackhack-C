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
        text.text = "外出時刻は　" + Data.getouttime.Hour + ":" + Data.getouttime.Minute + "　です";
    }
}
