using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float speed = 1f;

    public GameObject miniCubes;

    Vector3 vspeed;

    Vector3 pos;

    void Start() {
        vspeed = new Vector3(0, speed, 0);
        pos = transform.position;
    }

    void Update() {
        transform.position -= vspeed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider collider) {
        BulletShot bullet = collider.GetComponent<BulletShot>();
        if(bullet != null) {
            Debug.Log("Enemy destroyed");
            bullet.explore();
            GameObject obj = GameObject.Instantiate(miniCubes);
            obj.transform.position = transform.position - new Vector3(0, 0.25f, 0);
            Destroy(gameObject);
        } else if(collider.gameObject.name == "BaseTile") {
            Destroy(collider.gameObject);
        } else if(collider.gameObject.name == "Player") {
            Player.Instance.showMiniCubes();
            collider.gameObject.transform.position = new Vector3(0, 20f, 0);
            Player.Instance.fallDawn();
        }
    }

}