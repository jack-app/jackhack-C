using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatsudaiFade : MonoBehaviour
{
    public Text Matsudai;
    public float FadeAmount = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float A = 1f;
        if(A == 0f) { FadeAmount = FadeAmount * -1;
        }
        if(A== 255f) { FadeAmount = FadeAmount * -1;
        }
        A = A + FadeAmount * Time.deltaTime;
        Matsudai.color = new Color(0, 0, 0, A);
    }
}
