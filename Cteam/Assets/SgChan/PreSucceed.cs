using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreSucceed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Succeed()
    {
        Data.alarm = false;
        PlayerPrefs.SetInt("Alarm", 0);
        Data.getupdays += 1;
        PlayerPrefs.SetInt("GetUpDays", Data.getupdays);
        SceneManager.LoadScene("Succeed");
    }
}
