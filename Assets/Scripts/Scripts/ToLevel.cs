using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToLevel : MonoBehaviour
{
    public string levelName = "Level1";
    public Button buttonToLevel;

    void Start()
    {
        buttonToLevel.signalOnClick.AddListener(seput);
    }

    void seput()
    {
        SceneManager.LoadScene(levelName); 
    }
}