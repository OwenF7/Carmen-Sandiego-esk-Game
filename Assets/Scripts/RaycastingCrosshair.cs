using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class RaycastingCrosshair : MonoBehaviour
{
    public GameObject crosshair;
    public GameObject interactCrosshair;
    public GameObject interactTextObject;
    public Text interactText;

    public float raycastMaxDistance = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit; 

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, raycastMaxDistance))
        {
            crosshair.SetActive(false);
            interactCrosshair.SetActive(true);
            interactTextObject.SetActive(true); 

            if (hit.transform.name == "Taiwan")
            {
                interactText.text = "Press E Travel to Taiwan"; 

                //if
            }

            else if (hit.transform.name == "Germany")
            {
                interactText.text = "Press E Travel to Germany";

                //if
            }

            else
            {
                crosshair.SetActive(true);
                interactCrosshair.SetActive(false);
                interactTextObject.SetActive(false);
            }
        }

        else
        {
            crosshair.SetActive(true);
            interactCrosshair.SetActive(false);
            interactTextObject.SetActive(false);
        }
    }
}
