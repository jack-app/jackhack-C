using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TatchDog : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out hit))
        {
            if (hit.transform.tag == "Dog")
            {
                
            }
        }
    }
}
