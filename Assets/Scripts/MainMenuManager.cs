using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject Startbutton;
    public GameObject QuitButton1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Startbutton1()
    {
        SceneManager.LoadScene("Map");
    }

    public void QuitButton()
    {
        Application.Quit(0);
    }
}
