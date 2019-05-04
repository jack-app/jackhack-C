using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        int AnimNUM = Random.Range(1, 4);
        if (AnimNUM == 1)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Blush")
                && !anim.IsInTransition(0))
            {
                anim.SetTrigger("Blush");
            }
        }

        if (AnimNUM == 2)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Roar")
                && !anim.IsInTransition(0))
            {
                anim.SetTrigger("Roar");
            }
        }

        if (AnimNUM == 3)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Jump")
                && !anim.IsInTransition(0))
            {
                anim.SetTrigger("Jump");
            }
        }
    }
        
}
