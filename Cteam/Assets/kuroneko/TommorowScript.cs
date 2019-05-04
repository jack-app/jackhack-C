using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TommorowScript : MonoBehaviour
{
    Button btn;
    public static int flag;
    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("TommorowButton").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        flag = 1;
        button
    }
}
