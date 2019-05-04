using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Getupdays : MonoBehaviour
{
    public Text getupdaystext;
    // Start is called before the first frame update
    void Start()
    {
        getupdaystext.text =   "早起き"+(Data.getupdays+1)+"日目";
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
