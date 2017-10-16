using System;
using System.Collections;
using UnityEngine;
using UnityEngine.VR;

public class Throwobject : UnityEngine.MonoBehaviour
{

    [SerializeFeiled]
    private GameObject throwingObject;

    private Rigidbody objectRigidBody;

    private Vector3 startingPosition;
    private Quaternion startingRoation;

    private float objectForce = 0f;



    // Use this for initialization
    void Start () {

        objectRigidBody = throwingObject.GetComponent<Rigidbody> ();
        startingPosition = throwingObject.transform.localPosition;
        startingRoation = throwingObject.transform.localRotation;
        objectRigidBody.isKinematic = true;
	}
	// Update is called once per frame
	void Update () {
	
        // If the player has stared to click the mouse button
        if(Input.GetMouseButtonDown(0)){

           BeginThrow();

	}
        //If the player is continuing to hold down the mouse button...
        if (Input.GetMouseButton(0)) {

            PowerUpThrow();

        }

        //If the player releases the mouse button...
        if (Input.GetMouseButtonUp(0)){

            ReleaseObject();


        }
    
    private void BeginThrow() {

            //Reset physics
            objectRigidBody.isKinematic = true;
            objectRigidBody.velocity = Vector3.zero;
            objectRigidBody.angularVelocity = Vector3.zero;

        }
        

    private void ReleaseObject(){



            // Launch the object.
            objectRigidBody.isKinematic = false;
            throwingObject.transform.parent = null;
            objectRigidBody.AddRelativeForce(throwingObject.transform.forward * objectForce);
        }



    }

    private void ReleaseObject()
    {
        throw new NotImplementedException();
    }

    private void PowerUpThrow()
    {
        throw new NotImplementedException();
    }

    private void BeginThrow()
    {
        throw new NotImplementedException();
    }
}

internal class SerializeFeiledAttribute : Attribute
{
}