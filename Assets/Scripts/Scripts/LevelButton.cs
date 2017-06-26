using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelButton : MonoBehaviour
{

    public Button buttonLevel;

    void Start()
    {
        buttonLevel.signalOnClick.AddListener(toLevelMenu);
    }

    void toLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }
}