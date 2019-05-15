using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour {
    [SerializeField]
    private GameObject ovrCamera; 
    [SerializeField]
    private GameObject menuCanvas; 
    [SerializeField]
    private GameObject bioSound;
    [SerializeField]
    private GameObject chemSound;
    [SerializeField]
    private GameObject artSound;
    
    // Start is called before the first frame update
    void Start() {
        menuCanvas.SetActive(true);
        ovrCamera.transform.position = new Vector3(-25f, 1.07f, 2.85f);
        ovrCamera.transform.rotation = Quaternion.Euler(0, 360.5f, 0);
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void goToBiology () {
        menuCanvas.SetActive(false);
        ovrCamera.transform.position = new Vector3(5.33f, 0.95f, -3.88f); 
        bioSound.GetComponent<AudioSource>().Play();
        chemSound.GetComponent<AudioSource>().Stop();
        artSound.GetComponent<AudioSource>().Stop();
    }

    public void goToArt() {
        menuCanvas.SetActive(false);
        ovrCamera.transform.position = new Vector3(-4.47f, 0.28f, 9.09f);
        bioSound.GetComponent<AudioSource>().Stop();
        chemSound.GetComponent<AudioSource>().Stop();
        artSound.GetComponent<AudioSource>().Play();
    }

    public void goToChemistry() {
        menuCanvas.SetActive(false);
        ovrCamera.transform.position = new Vector3(-17.55f, 0.64f, -3.26f); 
        bioSound.GetComponent<AudioSource>().Stop();
        chemSound.GetComponent<AudioSource>().Play();
        artSound.GetComponent<AudioSource>().Stop();
    }

    public void goToMenu() {
        menuCanvas.SetActive(true);
        ovrCamera.transform.position = new Vector3(-25.05f, 1.07f, 3.05f);    
        bioSound.GetComponent<AudioSource>().Stop();
        chemSound.GetComponent<AudioSource>().Stop();
        artSound.GetComponent<AudioSource>().Stop();
    }
}
