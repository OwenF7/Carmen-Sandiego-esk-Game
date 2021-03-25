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

    public GameObject reportBox;
    public TextMeshProUGUI report;

    public string levelloader = "Level Loader";

    public float raycastMaxDistance = 5.0f;

    public bool reportReveal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject levelLoader = GameObject.FindGameObjectWithTag("LL").gameObject;

        RaycastHit hit;

        //Raycast, if statements regarding date and interactions

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, raycastMaxDistance))
        {
            crosshair.SetActive(false);
            interactCrosshair.SetActive(true);
            interactTextObject.SetActive(true);

            informationBox.SetActive(true);

            //Countries to Interact - 

            if (hit.transform.name == "Taiwan")
            {
                interactText.text = "Press E to send Agents to Taiwan";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Germany")
            {
                interactText.text = "Press E to send Agents to Germany";

                if (hit.transform.tag == "Sept 1939")
                {
                    intel.text = " Country: Germany \n City: Berlin \n Occupation: Germany \n Likelyhood to get caught: High (75%) \n Status: \n \n Ever since Germany has gotten their new leader, the people have been riled up. " +
                    "We even got intel recently that something is going on with the Jewish people. This might be worth investigating...";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //High Likelihood to get caught

                        float randValue = Random.value;

                        if (randValue < .75f) // 75% of the time
                        {
                            Debug.Log("Unsuccessful Report should appear");

                            report.text = "Your spies were caught, and you lost contact with them. No further information has made it to you...";
                        }

                        else if (randValue < .25f) // 25% of the time
                        {
                            Debug.Log("Successful Report should appear");

                            report.text = "Spies did not get caught.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                /*else if (hit.transform.tag == "Dec 1939")
                {
                    intel.text = " Country: Germany \n City: Berlin \n Occupation: \n Likelyhood to get caught: High \n Status: \n \n The belly of the beast. I shouldn't send agents here. It's too risky";
                }*/
            }

            else if (hit.transform.name == "Poland")
            {
                interactText.text = "Press E to send Agents to Poland";

                if (hit.transform.tag == "Sept 1939")
                {
                    intel.text = " Country: Poland \n City: Warsaw \n Occupation: Poland \n Likelyhood to get caught: Medium (30%) \n Status: \n \n We recently got a request for a meeting with some disturbing " +
                        "accusations. The Prime Minister seemed very on edge in the brief interaction with one of our agents. Something is coming.";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //Medium Likelihood to get caught

                        float randValue = Random.value;

                        if (randValue < .30f) // 30% of the time
                        {
                            Debug.Log("Unsuccessful Report should appear");

                            report.text = "Your spies were caught, and you lost contact with them. No further information has made it to you...";
                        }

                        else if (randValue < .70f) // 70% of the time
                        {
                            Debug.Log("Successful Report should appear");

                            report.text = "Spies did not get caught.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                /*else if (hit.transform.tag == "Dec 1939")
                {
                    intel.text = " Country: Poland \n City: Warsaw \n Occupation: Germany \n Likelyhood to get caught: High \n Status: \n \n Germany invaded here in September. We may be able to gleam " +
                        "some information out here...";
                }*/
            }

            else if (hit.transform.name == "France")
            {
                interactText.text = "Press E to send Agents to France";

                if (hit.transform.tag == "Sept 1939")
                {
                    intel.text = " Country: France \n City: Paris \n Occupation: France \n Likelyhood to get caught: Low (5%)\n Status: \n \n A meeting request with the French Spies. They are saying it is " +
                        "urgent. We probably shouldn't keep them waiting.";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //Low Likelihood to get caught

                        float randValue = Random.value;

                        if (randValue < .05f) // 5% of the time
                        {
                            Debug.Log("Unsuccessful Report should appear");

                            report.text = "Your spies were caught, and you lost contact with them. No further information has made it to you...";
                        }

                        else if (randValue < .95f) // 95% of the time
                        {
                            Debug.Log("Successful Report should appear");

                            report.text = "Spies did not get caught.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                /*else if (hit.transform.tag == "Dec 1939")
                {
                    intel.text = " Country: France \n City: Paris \n Occupation: France \n Likelyhood to get caught: High \n Status: \n \n As we have feared, it seems that we are in the midst of another " +
                        "World War...";
                }*/
            }

            else if (hit.transform.name == "Italy")
            {
                interactText.text = "Press E to send Agents to Italy";

                if (hit.transform.tag == "Dec 1939")
                {
                    intel.text = " Country: Italy \n City: Rome \n Occupation: Italy \n Likelyhood to get caught: High \n Status: \n \n Italy has been acting suspicious";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //High Likelihood to get caught

                        float randValue = Random.value;

                        if (randValue < .75f) // 75% of the time
                        {
                            //Debug.Log("Unsuccessful Report should appear");

                            report.text = "Your spies were caught, and you lost contact with them. No further information has made it to you...";
                        }

                        else if (randValue < .25f) // 25% of the time
                        {
                            //Debug.Log("Successful Report should appear");

                            report.text = "Spies did not get caught.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }
            }

            else if (hit.transform.name == "Spain")
            {
                interactText.text = "Press E to send Agents to Spain";

                if (hit.transform.tag == "Dec 1939")
                {
                    intel.text = " Country: Spain \n City: Madrid \n Occupation: Spain \n Likelyhood to get caught: Low \n Status: \n \n Spain has declared that they will be staying neutral in this " +
                        "conflict. They have indicated that they want no part in this war.";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //High Likelihood to get caught

                        float randValue = Random.value;

                        if (randValue < .75f) // 75% of the time
                        {
                            //Debug.Log("Unsuccessful Report should appear");

                            report.text = "Your spies were caught, and you lost contact with them. No further information has made it to you...";
                        }

                        else if (randValue < .25f) // 25% of the time
                        {
                            //Debug.Log("Successful Report should appear");

                            report.text = "Spies did not get caught.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }
            }

            else if (hit.transform.name == "Soviet Union")
            {
                interactText.text = "Press E to send Agents to the Soviet Union";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Sweden")
            {
                interactText.text = "Press E to send Agents to Sweden";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Finland")
            {
                interactText.text = "Press E to send Agents to Finland";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Great Britain")
            {
                interactText.text = "Press E to send Agents to Great Britain";

                Debug.Log("Hitting Great Britain");

                if (hit.transform.tag == "Dec 1939")
                {
                    Debug.Log("Hitting Great Britain and Dec 1939");

                    intel.text = " Country: Great Britain \n City: Madrid \n Occupation: Spain \n Likelyhood to get caught: Low \n Status: \n \n Spain has declared that they will be staying neutral in this " +
                        "conflict. They have indicated that they want no part in this war.";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //High Likelihood to get caught

                        float randValue = Random.value;

                        if (randValue < .75f) // 75% of the time
                        {
                            //Debug.Log("Unsuccessful Report should appear");

                            report.text = "Your spies were caught, and you lost contact with them. No further information has made it to you...";
                        }

                        else if (randValue < .25f) // 25% of the time
                        {
                            //Debug.Log("Successful Report should appear");

                            report.text = "Spies did not get caught.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }
            }

            else if (hit.transform.name == "Algeria")
            {
                interactText.text = "Press E to send Agents to Algeria";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Libya")
            {
                interactText.text = "Press E to send Agents to Libya";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Turkey")
            {
                interactText.text = "Press E to send Agents to Turkey";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Egypt")
            {
                interactText.text = "Press E to send Agents to Egypt";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Romania")
            {
                interactText.text = "Press E to send Agents to Romania";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Saudi Arabia")
            {
                interactText.text = "Press E to send Agents to Saudi Arabia";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Ethiopia")
            {
                interactText.text = "Press E to send Agents to Ethiopia";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Sudan")
            {
                interactText.text = "Press E to send Agents to Sudan";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Nigeria")
            {
                interactText.text = "Press E to send Agents to Nigeria";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Democratic Republic of the Congo")
            {
                interactText.text = "Press E to send Agents to the Democratic Republic of the Congo";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Yemen")
            {
                interactText.text = "Press E to send Agents to Yemen";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Afghanistan")
            {
                interactText.text = "Press E to send Agents to Afghanistan";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "India")
            {
                interactText.text = "Press E to send Agents to India";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Burma")
            {
                interactText.text = "Press E to send Agents to Burma";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Thailand")
            {
                interactText.text = "Press E to send Agents to Thailand";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "French Indochina")
            {
                interactText.text = "Press E to send Agents to the French Indochina";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Philippines")
            {
                interactText.text = "Press E to send Agents to the Philippines";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Australia")
            {
                interactText.text = "Press E to send Agents to Australia";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "New Guinea")
            {
                interactText.text = "Press E to send Agents to New Guinea";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Japan")
            {
                interactText.text = "Press E to send Agents to Japan";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Korea")
            {
                interactText.text = "Press E to send Agents to Korea";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "Manchuria")
            {
                interactText.text = "Press E to send Agents to Manchuria";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }

            else if (hit.transform.name == "China")
            {
                interactText.text = "Press E to send Agents to China";

                if (Input.GetKeyDown(KeyCode.E))
                {
                    levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                }
            }
            
            else
            {
                crosshair.SetActive(true);
                interactCrosshair.SetActive(false);
                interactTextObject.SetActive(false);

                informationBox.SetActive(false);
            }

            //Toggle for Report Box

            if (Input.GetKeyDown(KeyCode.R))
            {
                reportReveal = !reportReveal;

                if (reportReveal)
                {
                    //Debug.Log("reportReveal is on!");

                    reportBox.SetActive(true);
                }

                else
                {
                    //Debug.Log("reportReveal is off!");

                    reportBox.SetActive(false);
                }
            }
        }
    }
}
