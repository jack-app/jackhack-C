using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TommorowScript : MonoBehaviour
{
    Button btn;
    //翌日爆弾設定するならflagは1
    public static int flag;
    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.Find("TommorowButton").GetComponent<Button>();
        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        
    }
}
