﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour {

    //총알의 파괴력
    public float damage = 20.0f;

    //총알의 발사 속도
    public float speed = 2000.0f;

	// Use this for initialization
	void Start () {

        GetComponent<Rigidbody>().AddRelativeForce(transform.forward * speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
