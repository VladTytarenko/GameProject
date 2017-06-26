using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape) && gameObject.activeInHierarchy)
        //{ // KeyCode.return
            //if(gameObject.activeInHierarchy == true)
            Application.LoadLevel(0);
        //}

	}
}
