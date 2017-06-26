using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public int playerScore = 0;

    void Start () {

    }

	void Update () {
        if(!isGrounded()) {
            StartCoroutine (Player.Instance.fallDawn());
            return;
        } else {
            if(Input.GetKeyDown(KeyCode.A)) {
                transform.Translate(Constants.left);
            } else if(Input.GetKeyDown(KeyCode.D)) {
                transform.Translate(Constants.right);
            } else if(Input.GetKeyDown(KeyCode.W)) {
                transform.Translate(Constants.up);
            } else if(Input.GetKeyDown(KeyCode.S)) {
                transform.Translate(Constants.down);
            } else if(Input.GetKeyDown(KeyCode.Space)) {
                //Rigidbody clone;
                //clone = Instantiate(projectile, transform.position+new Vector3(0,1f, 0), transform.rotation) as Rigidbody;
                //clone.AddRelativeForce (new Vector3(0, 400f, 0));
                //clone.gameObject.GetComponent<Collider>().enabled = true;
                Player.Instance.shot();
            } else if(Input.GetKeyDown(KeyCode.Pause)) {
            }
        }
	}

    bool isGrounded() {
        if(transform.position.y < 0.9) return false;
        return true;
    }

}
