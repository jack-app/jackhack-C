using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentFade : MonoBehaviour
{
    public float FadeTime = 1f;
    public float LifeTime = 0f;
    private SpriteRenderer SPR;
    // Start is called before the first frame update
    void Start()
    {
        LifeTime = FadeTime;
        SPR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        LifeTime -= Time.deltaTime;
        if(LifeTime <= 0f)
        {
            GameObject.Destroy(gameObject);
            return;
        }
        float A = LifeTime / FadeTime;
        var color = SPR.color;
        color.a = A;
    }
}
