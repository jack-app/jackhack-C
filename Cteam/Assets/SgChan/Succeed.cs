using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Succeed : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("MainScene", 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

}
