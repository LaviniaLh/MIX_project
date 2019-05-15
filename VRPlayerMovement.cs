using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlayerMovement : MonoBehaviour {
    Vector2 joystick;
    public float speed = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        joystick = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        transform.Translate(Vector3.forward * speed * joystick.y * Time.deltaTime);
        transform.Translate(Vector3.right * speed * joystick.x * Time.deltaTime);
        myCamera.transform.position = Vector3.Lerp(myCamera.transform.position, transform.position, 10f * Time.deltaTime);
        */

        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKey("w")){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

	}
}
