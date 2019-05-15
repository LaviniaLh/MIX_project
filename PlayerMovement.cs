using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 1.0f;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    public GameObject myCamera;
    private Vector2 mouseLook;
    private Vector2 smoothV;

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        //front and back

        
        float transVertical = Input.GetAxis("Vertical") * speed;
        float transHorizontal = Input.GetAxis("Horizontal") * speed;
        transVertical *= Time.deltaTime;
        transHorizontal *= Time.deltaTime;
        if (Input.GetAxis("Vertical") != 0)
        { 
            Debug.Log(transVertical);
        }

            transform.Translate(transHorizontal, 0, transVertical);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

        //rotate
        var mouseDirection = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mouseDirection = Vector2.Scale(mouseDirection, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, mouseDirection.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, mouseDirection.y, 1f / smoothing);

        mouseLook += smoothV;

        myCamera.transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        transform.localRotation = Quaternion.AngleAxis(mouseLook.x, transform.up);



    }
}
