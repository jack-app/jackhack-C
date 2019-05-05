using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    int rot;
    GameObject dog;
    // Start is called before the first frame update
    void Start()
    {
        dog = GameObject.Find("DoG");
        rot = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (rot!=0)
        {
            dog.transform.Rotate(0, -2 * rot, 0);
        }
    }

    public void RClick()
    {
        rot = 1;
    }

    public void LClick()
    {
        rot = -1;
    }

    public void RotFinish()
    {
        rot = 0;
    }
}
