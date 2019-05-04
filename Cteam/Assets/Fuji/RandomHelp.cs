using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHelp : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int RANNUM = Random.Range(1, 4);
        var BornSpot = GameObject.Find("RandomSpot" + RANNUM);
        Vector3 pos = BornSpot.transform.position;
        this.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
