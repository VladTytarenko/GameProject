using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCube : MonoBehaviour {

    public float lifeTime = 1f;

    void Start() {
        StartCoroutine(selfDestruction());
    }

    IEnumerator selfDestruction() {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player") {
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        }
    }
}
