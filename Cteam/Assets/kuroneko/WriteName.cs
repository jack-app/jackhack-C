using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WriteName : MonoBehaviour
{
    // Start is called before the first frame update
    Text nameText;

    void Start()
    {
        nameText = GameObject.Find("nameText").GetComponent<Text>();
        nameText.text = Data.dogname;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        SceneManager.LoadScene("NameScene");
    }
}
