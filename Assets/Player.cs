using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Player Instance;

    public GameObject miniCubes;

    Vector3 startPosition = new Vector3(0, 3, 0);

    float waitTimeForFall = 1.5f;

    int score = 0;
    int lifes = 0;

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

    public void setScore(int _score) {
        score = _score;
    }

    public void setLifes(int _lifes) {
        lifes = _lifes;
    }

    public int getScore() {
        return score;
    }

    public int getLifes() {
        return lifes;
    }

    public void showMiniCubes() {
        GameObject obj = GameObject.Instantiate(miniCubes);
        obj.transform.position = transform.position - new Vector3(0, 0.25f, 0);
    }

}
