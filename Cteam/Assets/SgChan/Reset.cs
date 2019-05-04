using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DataReset()
    {
        PlayerPrefs.DeleteKey("GetUpTime");
        PlayerPrefs.DeleteKey("GetOutTime");
        PlayerPrefs.DeleteKey("DogName");
        PlayerPrefs.DeleteKey("GetUpDays");
        SceneManager.LoadScene("MainScene");

    }
}
