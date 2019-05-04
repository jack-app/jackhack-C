using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameBtnDestroy : MonoBehaviour
{
    Button namebtn;
    // Start is called before the first frame update
    void Start()
    {
        namebtn = GameObject.Find("NameButton").GetComponent<Button>();
        if (Data.dogname == "")
            Destroy(namebtn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
