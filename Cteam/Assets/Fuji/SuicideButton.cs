using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuicideButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoOff() {
        SceneManager.LoadScene("Dead");
    }
}