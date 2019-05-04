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
        if (Input.touchCount > 0)
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                print("hit");
                if (hit.transform.tag == "Dog")
                {
                    print("Dog");
                    hit.transform.GetComponent<Dog>().Jump();
                }
            }
        }

       
    }
}
