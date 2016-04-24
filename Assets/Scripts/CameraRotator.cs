﻿using UnityEngine;
using System.Collections;

public class CameraRotator : MonoBehaviour {

    public float speed = 5;

	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);

    }
}
