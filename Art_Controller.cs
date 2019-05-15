using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Art_Controller : MonoBehaviour {

    [SerializeField]
    private Button blue;
    [SerializeField]
    private Button yellow;
    [SerializeField]
    private Button red;
    [SerializeField]
    private Button green;
    [SerializeField]
    private Button white;
    [SerializeField]
    private Button black;
    [SerializeField]
    private Material brush_red;
    [SerializeField]
    private Material brush_yellow;
    [SerializeField]
    private Material brush_blue;
    [SerializeField]
    private Material brush_green;
    [SerializeField]
    private Material brush_white;
    [SerializeField]
    private Material brush_black;
    [SerializeField]
    private Renderer brush;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void onClickBlue()
    {
        brush.material = brush_blue;

    }
    public void onClickYellow()
    {
        brush.material = brush_yellow;

    }
    public void onClickRed()
    {
        brush.material = brush_red;

    }
    public void onClickGreen()
    {
        brush.material = brush_green;

    }
    public void onClickWhite()
    {
        brush.material = brush_white;

    }
    public void onClickBlack()
    {
        brush.material = brush_black;

    }
}
