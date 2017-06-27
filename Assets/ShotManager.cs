using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotManager : MonoBehaviour {

    public static ShotManager Instance;

    public Rigidbody bulletPrefab;

    public float pauseTime = 0.5f;

    public float shotPower = 700;

    float pauseTimer = -1;

    bool isShotable = true;

	void Start () {
        Instance = this;
	}
	
	void Update () {
		if(!isShotable) {
            waitForShotable();
        }
	}

    public void shot() {
        if(isShotable) {
            shotableToggle();
            setTimer();
            Debug.Log("Bu-buh!");
            Vector3 ppos = Player.Instance.transform.position;
            Rigidbody bPrefab = Instantiate(bulletPrefab, new Vector3(ppos.x, ppos.y + 0.5f, ppos.z), Quaternion.identity) as Rigidbody;
            bPrefab.AddForce(Vector3.up * shotPower);
        }
    }

    void waitForShotable() {
        pauseTimer -= Time.deltaTime;
        if(pauseTimer <= 0) shotableToggle();
    }

    void setTimer() {
        pauseTimer = pauseTime;
    }

    void shotableToggle() {
        isShotable = !isShotable;
    }

}
