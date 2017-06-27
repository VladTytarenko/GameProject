using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public GameObject Player;

	void Update () {

        if (Input.GetKeyDown(KeyCode.Return) && gameObject.activeInHierarchy)
        {
            //{ // KeyCode.return
            //if(gameObject.activeInHierarchy == true)
            //TopResults.add(0);
            TopResults.add(Player.GetComponent<InputManager>().playerScore);
            //Application.LoadLevel(0);
            SceneManager.LoadScene("Level2");
            //}
        }

	}
}
