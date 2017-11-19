using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BirdMovement : MonoBehaviour {

    [SerializeField]
    private Transform target;
    private NavMeshAgent birdAgent;
    private Animator birdanimator;
        


	// Use this for initialization
	void Start () {
        birdAgent = GetComponent<NavMeshAgent>();
        birdanimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        //set the bird destination
        birdAgent.SetDestination (target.position);

        //Measure the magnitude of the NavMeshAgent's velocity
        float speed = birdAgent.velocity.magnitude;

        //Pass the velocity ti the animator component
        birdanimator.SetFloat("Speed", speed);

	}
}
