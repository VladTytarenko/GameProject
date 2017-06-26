using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Player Instance;

    Vector3 startPosition = new Vector3(0, 3, 0);

    float waitTimeForFall = 1.5f;

    void Start() {
        Instance = this;
    }

    public IEnumerator fallDawn() {

        yield return new WaitForSeconds(waitTimeForFall);

        Rigidbody rigibody = GetComponent<Rigidbody>();
        rigibody.isKinematic = true;
        rigibody.velocity = Vector3.zero;
        transform.rotation = new Quaternion();
        transform.position = startPosition;
        rigibody.isKinematic = false;
    }

    public void shot() {
        ShotManager.Instance.shot();
    }

}
