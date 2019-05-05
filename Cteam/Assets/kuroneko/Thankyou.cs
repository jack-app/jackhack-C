using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thankyou : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("DoG").GetComponent<Animator>();
        anim.SetTrigger("Roar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
