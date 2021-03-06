﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPickup : MonoBehaviour {

    [SerializeField]
    private GameObject pickupPrefab;



    void OnTriggerEnter(Collider other) {
        
        // If the Collider other is tagged with "Player"...
        if (other.CompareTag ("Player")){


            //...add the pickup particles...
            Instantiate(pickupPrefab,transform.position,Quaternion.identity);

            //..decrement the total num of flies..
            FlySpawner.totalFlies--;

            //...update the score...
            ScoreCounter.score++;

            Destroy(gameObject);
        
        }

    }


}