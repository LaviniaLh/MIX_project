using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Art_Paint : MonoBehaviour {

    public GameObject Brush;
    public GameObject plane;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) || OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.name == "Paper")
                {
                    var go = Instantiate(Brush, hit.point + new Vector3(0f, 0.25f, 0f), Quaternion.identity, transform);
                }
            }

            /*
            var Ray = myCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit))
            {
                if (hit.transform.gameObject.name == "Paper")
                {
                    var go = Instantiate(Brush, hit.point + new Vector3(0f, 0.25f, 0f), Quaternion.identity, transform);
                }

            }*/

        }
    }
}
