﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot : MonoBehaviour {

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

}
