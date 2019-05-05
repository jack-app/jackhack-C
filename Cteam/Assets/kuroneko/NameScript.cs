using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameScript : MonoBehaviour
{
    public static string dogname;
    InputField nameField;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        nameField = GameObject.Find("nameField").GetComponent<InputField>();
        nameField.text = Data.dogname;
        anim = GameObject.Find("DoG").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecideName()
    {
        dogname = nameField.text;
        Debug.Log(dogname);
        PlayerPrefs.SetString("DogName", dogname);
        anim.SetTrigger("Jump");
    }

    public void OnClick()
    {
        SceneManager.LoadScene("SettingScene");
    }
}
