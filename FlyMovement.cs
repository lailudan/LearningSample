﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour {

    [SerializeField]
    private Transform Center;

    private float flySpeed;

	// Use this for initialization
	void Start () {
        flySpeed = Random.Range(300f, 700f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Center.position, Vector3.up, flySpeed * Time.deltaTime);	
	}
}
