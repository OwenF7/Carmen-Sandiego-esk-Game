using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class RaycastingCrosshair : MonoBehaviour
{
    public GameObject crosshair;
    public GameObject interactCrosshair;

    public GameObject interactTextObject;
    public TextMeshProUGUI interactText;

    public GameObject informationBox;
    public TextMeshProUGUI intel;

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

            informationBox.SetActive(true);

            if (hit.transform.name == "Taiwan")
            {
                interactText.text = "Press E to send Agents to Taiwan";

                //if
            }

            else if (hit.transform.name == "Germany")
            {
                interactText.text = "Press E to send Agents to Germany";

                if (hit.transform.tag == "Sept 1939")
                {
                    intel.text = " Country: Germany \n City: Berlin \n Occupation: \n Likelyhood to get caught: High \n Status: \n \n Ever since Germany has gotten their new leader, the people have been riled up. " +
                    "We even got intel recently that something is going on with the Jewish people. This might be worth investigating...";
                }

                else if (hit.transform.tag == "Dec 1939")
                {
                    intel.text = "This would be the second text.";
                }

                //if
            }

            else if (hit.transform.name == "Poland")
            {
                interactText.text = "Press E to send Agents to Poland";

                //if
            }

            else if (hit.transform.name == "France")
            {
                interactText.text = "Press E to send Agents to France";

                //if
            }

            else if (hit.transform.name == "Italy")
            {
                interactText.text = "Press E to send Agents to Italy";

                //if
            }

            else if (hit.transform.name == "Spain")
            {
                interactText.text = "Press E to send Agents to Germany";

                //if
            }

            else if (hit.transform.name == "Soviet Union")
            {
                interactText.text = "Press E to send Agents to the Soviet Union";

                //if
            }

            else if (hit.transform.name == "Sweden")
            {
                interactText.text = "Press E to send Agents to Sweden";

                //if
            }

            else if (hit.transform.name == "Finland")
            {
                interactText.text = "Press E to send Agents to Finland";

                //if
            }

            else if (hit.transform.name == "Great Britain")
            {
                interactText.text = "Press E to send Agents to Great Britain";

                //if
            }

            else if (hit.transform.name == "Algeria")
            {
                interactText.text = "Press E to send Agents to Algeria";

                //if
            }

            else if (hit.transform.name == "Libya")
            {
                interactText.text = "Press E to send Agents to Libya";

                //if
            }

            else if (hit.transform.name == "Turkey")
            {
                interactText.text = "Press E to send Agents to Turkey";

                //if
            }

            else if (hit.transform.name == "Egypt")
            {
                interactText.text = "Press E to send Agents to Egypt";

                //if
            }

            else if (hit.transform.name == "Romania")
            {
                interactText.text = "Press E to send Agents to Romania";

                //if
            }

            else if (hit.transform.name == "Saudi Arabia")
            {
                interactText.text = "Press E to send Agents to Saudi Arabia";

                //if
            }

            else if (hit.transform.name == "Ethiopia")
            {
                interactText.text = "Press E to send Agents to Ethiopia";

                //if
            }

            else if (hit.transform.name == "Sudan")
            {
                interactText.text = "Press E to send Agents to Sudan";

                //if
            }

            else if (hit.transform.name == "Nigeria")
            {
                interactText.text = "Press E to send Agents to Nigeria";

                //if
            }

            else if (hit.transform.name == "Democratic Republic of the Congo")
            {
                interactText.text = "Press E to send Agents to the Democratic Republic of the Congo";

                //if
            }

            else if (hit.transform.name == "Yemen")
            {
                interactText.text = "Press E to send Agents to Yemen";

                //if
            }

            else if (hit.transform.name == "Afghanistan")
            {
                interactText.text = "Press E to send Agents to Afghanistan";

                //if
            }

            else if (hit.transform.name == "India")
            {
                interactText.text = "Press E to send Agents to India";

                //if
            }

            else if (hit.transform.name == "Burma")
            {
                interactText.text = "Press E to send Agents to Burma";

                //if
            }

            else if (hit.transform.name == "Thailand")
            {
                interactText.text = "Press E to send Agents to Thailand";

                //if
            }

            else if (hit.transform.name == "French Indochina")
            {
                interactText.text = "Press E to send Agents to the French Indochina";

                //if
            }

            else if (hit.transform.name == "Philippines")
            {
                interactText.text = "Press E to send Agents to the Philippines";

                //if
            }

            else if (hit.transform.name == "Australia")
            {
                interactText.text = "Press E to send Agents to Australia";

                //if
            }

            else if (hit.transform.name == "New Guinea")
            {
                interactText.text = "Press E to send Agents to New Guinea";

                //if
            }

            else if (hit.transform.name == "Japan")
            {
                interactText.text = "Press E to send Agents to Japan";

                //if
            }

            else if (hit.transform.name == "Korea")
            {
                interactText.text = "Press E to send Agents to Korea";

                //if
            }

            else if (hit.transform.name == "Manchuria")
            {
                interactText.text = "Press E to send Agents to Manchuria";

                //if
            }

            else if (hit.transform.name == "China")
            {
                interactText.text = "Press E to send Agents to China";

                //if
            }

            else
            {
                crosshair.SetActive(true);
                interactCrosshair.SetActive(false);
                interactTextObject.SetActive(false);

                informationBox.SetActive(false);
            }
        }

        else
        {
            crosshair.SetActive(true);
            interactCrosshair.SetActive(false);
            interactTextObject.SetActive(false);

            informationBox.SetActive(false);
        }
    }
}
