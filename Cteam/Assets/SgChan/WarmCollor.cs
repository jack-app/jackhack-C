using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarmCollor : MonoBehaviour
{
    // Start is called before the first frame update

    public Image image;
    float time;
    public float speed;
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = (time + speed*Time.deltaTime) % 2 ;
        image.color = new Color(255, 0, 0, Mathf.Sin(time*Mathf.PI)/2);
    }
}
