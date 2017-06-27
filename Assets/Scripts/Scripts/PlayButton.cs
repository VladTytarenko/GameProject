using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour
{

    public Button button;

    void Start()
    {
        button.signalOnClick.AddListener(run);
    }
    
    void run()
    {
        SceneManager.LoadScene("LevelMenu");
    }
}
