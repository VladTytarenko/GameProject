using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public GameObject Player;

	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape) && gameObject.activeInHierarchy)
            //{ // KeyCode.return
            //if(gameObject.activeInHierarchy == true)
            //TopResults.add(0);
            TopResults.add(Player.GetComponent<InputManager>().playerScore);
            Application.LoadLevel(0);
        //}

	}
}
