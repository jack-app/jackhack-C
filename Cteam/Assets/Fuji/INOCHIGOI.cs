using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class INOCHIGOI : MonoBehaviour
{
   public GameObject[] TypesOfHelps;
    public int min = 1;
    public int max = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Touch T = Input.GetTouch(0);
        if (T.phase == TouchPhase.Began) {
            int HelpNUM = Random.Range(min, max);
            Instantiate(TypesOfHelps[HelpNUM]);
    } }
}
