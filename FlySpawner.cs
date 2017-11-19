﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour {

    [SerializeField]
    private GameObject flyPrefab;

    [SerializeField]
    private int totalFlyMinimum = 12;

    private float spawnArea = 25f;

    public static int totalFlies;

	// Use this for initialization
	void Start () {
        totalFlies = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
        //While the total num of flies is less than minium...
        while (totalFlies < totalFlyMinimum) {

            //... then increment the total number of flies...
            totalFlies++;

            //...create a random position for a fly...
            float positionX = Random.Range(-spawnArea,spawnArea);
            float positionZ = Random.Range(-spawnArea, spawnArea);

            Vector3 flyPositon = new Vector3(positionX,2f,positionZ);

            //...and create a new fly.
            Instantiate(flyPrefab,flyPositon,Quaternion.identity);
            
        }


	}
}