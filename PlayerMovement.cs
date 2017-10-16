using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Animator playerAnimator;
    private float moveHorizontal;
    private float moveVertical;
    private Vector3 movement;
    private float turningspeed = 20f;
    private Rigidbody playerRigidbody;

    

	// Use this for initialization
	void Start () {
       
        // Gather components from the player GamObject
        playerAnimator = GetComponent<Animator>();

        playerRigidbody = GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {

        //Gather input from keyboard
        moveHorizontal = Input.GetAxisRaw ("Horizontal");
        moveVertical = Input.GetAxisRaw ("Vertical");

        movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
	}

    void FixedUpdate () {

        //if the player's movement vectors does not equal to zero...
        if (movement != Vector3.zero){

            //...then create a target rotation based on the mocement vetcor...
            Quaternion targetRoatation = Quaternion.LookRotation(movement, Vector3.up);

            //...and create another rotation that move from the current location
            Quaternion newRotation = Quaternion.Lerp(playerRigidbody.rotation, targetRoatation, turningspeed * Time.deltaTime);

            //...and change the player's roation to the new incremental roation...
            playerRigidbody.MoveRotation(newRotation);

            // ... then play the jump animation.
            playerAnimator.SetFloat ("Speed", 3f);

        } else {
            // otherwise, don't play the jump animation.
            playerAnimator.SetFloat ("Speed", 0f);
        }     
        

    }


}
    