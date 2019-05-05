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
    AudioSource dog;
    
    // Start is called before the first frame update
    void Start()
    {
        nameField = GameObject.Find("nameField").GetComponent<InputField>();
        nameField.text = Data.dogname;
        anim = GameObject.Find("DoG").GetComponent<Animator>();
        dog = GameObject.Find("dog3(1)").GetComponent<AudioSource>();
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
        anim.SetTrigger("Roar");
        dog.Play();
    }

    public void OnClick()
    {
        SceneManager.LoadScene("SettingScene");
    }
}
