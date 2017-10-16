using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {


    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector3 offset;
    private float cameraFollewSpeed = 5f;
   

    // Update is called once per frame
    void Update () {
        Vector3 newPosition = player.position + offset;

        transform.position = Vector3.Lerp(transform.position,newPosition, cameraFollewSpeed * Time.deltaTime);
	}
}
