using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public int playerScore = 0;

    void Start () {

    }

	void Update () {
        if(!fallDown()) {
            StartCoroutine (Player.Instance.fallDawn());
            return;
        } else {
            if(!isGrounded()) return;

            if(Input.GetKeyDown(KeyCode.A)) {
                transform.Translate(Constants.left);
            } else if(Input.GetKeyDown(KeyCode.D)) {
                transform.Translate(Constants.right);
            } else if(Input.GetKeyDown(KeyCode.W)) {
                transform.Translate(Constants.up);
            } else if(Input.GetKeyDown(KeyCode.S)) {
                transform.Translate(Constants.down);
            } else if(Input.GetKeyDown(KeyCode.Space)) {
                Player.Instance.shot();
            } else if(Input.GetKeyDown(KeyCode.Pause)) {
            }
        }
	}

    bool fallDown() {
        if(transform.position.y < 0.9) return false;
        return true;
    }

    bool isGrounded() {
        return Physics.Raycast(transform.position, -Vector3.up, 0.5f + 0.1f);
    }

}
