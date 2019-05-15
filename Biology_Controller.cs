using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Biology_Controller : MonoBehaviour {

    [SerializeField]
    private GameObject information_upper;
    [SerializeField]
    private GameObject buttons_upper;
    [SerializeField]
    private GameObject information_skeleton;
    [SerializeField]
    private GameObject buttons_skeleton;
    [SerializeField]
    private GameObject information_brain;
    [SerializeField]
    private GameObject buttons_brain;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void buttonUpperBody(Button button) {
        buttons_upper.SetActive(false);
        information_upper.SetActive(true);
        Text text = information_upper.GetComponentInChildren<Text>();
        if (button.name == "Brain")
            text.text = "The brain is the control center for the vertebrate body";
        else if (button.name == "Eye")
            text.text = "The pupil is an opening in the center of the iris";
        else if (button.name == "Traheea")
            text.text = "Trachea is a tube that carries air directly to the cells";
        else if (button.name == "Lungs")
            text.text = "The lungs are a pair of spongy, saclike organs where gas exchange occurs";
        else
            text.text = "The heart is a muscular organ that pumps blood to all parts of the body";
    }

    public void onCloseInfoUpperBody() {
        information_upper.SetActive(false);
        buttons_upper.SetActive(true);

    }
    public void buttonSkeleton(Button button)
    {
        buttons_skeleton.SetActive(false);
        information_skeleton.SetActive(true);
        Text text = information_skeleton.GetComponentInChildren<Text>();
        if (button.name == "Skull")
            text.text = "Cranium, Mandible and Maxilla";
        else if (button.name == "Shoulder")
            text.text = "Clavicle and Scapula";
        else if (button.name == "Chest")
            text.text = "Sternum and Ribs";
        else if (button.name == "Arm")
            text.text = "Humerus, Radius and Ulna";
        else if (button.name == "Hand")
            text.text = "Carpals, Metacarpals and Phalanges";
        else if (button.name == "Spine")
            text.text = "Cervical(7), Thoracic(12), Lumbar(5), Sacrum(5) and Coccyx";
        else if (button.name == "Pelvic")
            text.text = "Ilium, Pubis and Ischium";
        else if (button.name == "Leg")
            text.text = "Ferum, Tibia and Fibula";
        else if (button.name == "Foot")
            text.text = "Tarsals, Metatarsals and Phalanges";
    }
    public void onCloseInfoSkeleton()
    {
        information_skeleton.SetActive(false);
        buttons_skeleton.SetActive(true);
    }

    public void buttonBrain(Button button)
    {
        buttons_brain.SetActive(false);
        information_brain.SetActive(true);
        Text text = information_brain.GetComponentInChildren<Text>();
        if (button.name == "Blue")
            text.text = "Frontal Lobe. Thinking/imagination";
        else if (button.name == "Green")
            text.text = "Temporal Lobe. Sound & Speech Processing";
        else if (button.name == "Red")
            text.text = "Occipital Lobe. Visual Processing";
        else if (button.name == "Yellow")
            text.text = "Parietal Lobe. Sensory Input & Body Orientation";
    }
    
    public void onCloseInfoBrain()
    {
        information_brain.SetActive(false);
        buttons_brain.SetActive(true);
    }
}
