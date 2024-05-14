using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMap : MonoBehaviour
{

    public GameObject mapButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Mapbutton()
    {
        SceneManager.LoadScene(1);
    }
}
