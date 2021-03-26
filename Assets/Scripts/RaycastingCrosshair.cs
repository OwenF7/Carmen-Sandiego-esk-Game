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

                if (hit.transform.tag == "Dec 1944")
                {
                    intel.text = " Country: Taiwan \n Capital: Taihoku \n Occupation: Axis Alliance \n Likelyhood to get caught: High \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Oct 1945")
                {
                    intel.text = " Country: Taiwan \n Capital: Taihoku \n Occupation: Allied Powers \n Likelyhood to get caught: High \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Germany")
            {
                interactText.text = "Press E to send Agents to Germany";

                if (hit.transform.tag == "Sept 1939")
                {
                    intel.text = " Country: Germany \n Capital: Berlin \n Occupation: Germany \n Likelyhood to get caught: High (75%) \n Status: \n \n Ever since Germany has gotten their new leader, the people have been riled up. " +
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

                else if (hit.transform.tag == "Aug 1945")
                {
                    intel.text = " Country: Germany \n Capital: Berlin \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Poland")
            {
                interactText.text = "Press E to send Agents to Poland";

                if (hit.transform.tag == "Sept 1939")
                {
                    intel.text = " Country: Poland \n Capital: Warsaw \n Occupation: Poland \n Likelyhood to get caught: Medium (30%) \n Status: \n \n We recently got a request for a meeting with some disturbing " +
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

                else if (hit.transform.tag == "Aug 1945")
                {
                    intel.text = " Country: Poland \n Capital: Warsaw \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n We recently got a request for a meeting with some disturbing " +
                        "accusations. The Prime Minister seemed very on edge in the brief interaction with one of our agents. Something is coming.";

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
            }

            else if (hit.transform.name == "France")
            {
                interactText.text = "Press E to send Agents to France";

                if (hit.transform.tag == "Sept 1939")
                {
                    intel.text = " Country: France \n Capital: Paris \n Occupation: Neutral \n Likelyhood to get caught: Low (5%) \n Status: \n \n A meeting request with the French Spies. They are saying it is " +
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

                else if (hit.transform.tag == "Mar 1945")
                {
                    intel.text = " Country: France \n Capital: Paris \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Italy")
            {
                interactText.text = "Press E to send Agents to Italy";

                if (hit.transform.tag == "Dec 1939")
                {
                    intel.text = " Country: Italy \n Capital: Rome \n Occupation: Neutral \n Likelyhood to get caught: High \n Status: \n \n Italy has been acting suspicious";

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

                else if (hit.transform.tag == "Jun 1945")
                {
                    intel.text = " Country: Italy \n Capital: Rome \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n Italy has been acting suspicious";

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
            }

            else if (hit.transform.name == "Spain")
            {
                interactText.text = "Press E to send Agents to Spain";

                if (hit.transform.tag == "Dec 1939")
                {
                    intel.text = " Country: Spain \n Capital: Madrid \n Occupation: Neutral \n Likelyhood to get caught: Low \n Status: \n \n Spain has declared that they will be staying neutral in this " +
                        "conflict. They have indicated that they want no part in this war.";

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
            }

            else if (hit.transform.name == "Soviet Union")
            {
                interactText.text = "Press E to send Agents to the Soviet Union";

                if (hit.transform.tag == "Dec 1941")
                {
                    intel.text = " Country: Soviet Union \n Capital: Moscow \n Occupation: Allied Powers \n Likelyhood to get caught: High \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Mar 1944")
                {
                    intel.text = " Country: Soviet Union \n Capital: Moscow \n Occupation: Allied Powers \n Likelyhood to get caught: High \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Sweden")
            {
                interactText.text = "Press E to send Agents to Sweden";

                if (hit.transform.tag == "Dec 1941")
                {
                    intel.text = " Country: Sweden \n Capital: Stockholm \n Occupation: Neutral \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Finland")
            {
                interactText.text = "Press E to send Agents to Finland";

                if (hit.transform.tag == "Dec 1941")
                {
                    intel.text = " Country: Finland \n Capital: Helsinki \n Occupation: Finland \n Likelyhood to get caught: Low \n Status: \n \n ---";

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //Low Likelihood to get caught

                        float randValue = Random.value;

                        if (randValue < .05f) // 05% of the time
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

                else if (hit.transform.tag == "Oct 1945")
                {
                    intel.text = " Country: Finland \n Capital: Helsinki \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Great Britain")
            {
                interactText.text = "Press E to send Agents to Great Britain";

                if (hit.transform.tag == "Dec 1939")
                {
                    intel.text = " Country: Great Britain \n Capital: London \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Dec 1944")
                {
                    intel.text = " Country: Great Britain \n Capital: London \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Algeria")
            {
                interactText.text = "Press E to send Agents to Algeria";

                if (hit.transform.tag == "Jun 1940")
                {
                    intel.text = " Country: Algeria \n Capital: Algiers \n Occupation: Allied Powers \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Libya")
            {
                interactText.text = "Press E to send Agents to Libya";

                if (hit.transform.tag == "Sept 1940")
                {
                    intel.text = " Country: Libya \n Capital: Tripoli \n Occupation: Axis Alliance \n Likelyhood to get caught: High \n Status: \n \n ---";

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
                            //Debug.Log("Successful Report should appear");

                            report.text = "Spies did not get caught.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }
            }

            else if (hit.transform.name == "Turkey")
            {
                interactText.text = "Press E to send Agents to Turkey";

                if (hit.transform.tag == "Jun 1941")
                {
                    intel.text = " Country: Turkey \n Capital: Ankara \n Occupation: Neutral \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Jun 1945")
                {
                    intel.text = " Country: Turkey \n Capital: Ankara \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Egypt")
            {
                interactText.text = "Press E to send Agents to Egypt";

                if (hit.transform.tag == "Jun 1941")
                {
                    intel.text = " Country: Egypt \n Capital: Cairo \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Dec 1944")
                {
                    intel.text = " Country: Egypt \n Capital: Cairo \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Romania")
            {
                interactText.text = "Press E to send Agents to Romania";

                if (hit.transform.tag == "Mar 1945")
                {
                    intel.text = " Country: Romania \n Capital: Bucharest \n Occupation: Allied Powers \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Saudi Arabia")
            {
                interactText.text = "Press E to send Agents to Saudi Arabia";

                if (hit.transform.tag == "Jun 1941")
                {
                    intel.text = " Country: Saudi Arabia \n Capital: Riyadh \n Occupation: Neutral \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Ethiopia")
            {
                interactText.text = "Press E to send Agents to Ethiopia";

                if (hit.transform.tag == "Sept 1940")
                {
                    intel.text = " Country: Ethiopia \n Capital: Addis Ababa \n Occupation: Axis Alliance \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Sudan")
            {
                interactText.text = "Press E to send Agents to Sudan";

                if (hit.transform.tag == "Jun 1940")
                {
                    intel.text = " Country: Sudan \n Capital: Khartoum \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Nigeria")
            {
                interactText.text = "Press E to send Agents to Nigeria";

                if (hit.transform.tag == "Jun 1940")
                {
                    intel.text = " Country: Nigeria \n Capital: Abuja \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Sept 1945")
                {
                    intel.text = " Country: Nigeria \n Capital: Abuja \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Democratic Republic of the Congo")
            {
                interactText.text = "Press E to send Agents to the Democratic Republic of the Congo";

                if (hit.transform.tag == "Sept 1940")
                {
                    intel.text = " Country: Democratic Republic of the Congo \n Capital: L�opoldville \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Yemen")
            {
                interactText.text = "Press E to send Agents to Yemen";

                if (hit.transform.tag == "Mar 1942")
                {
                    intel.text = " Country: Yemen \n Capital: Sana'a \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Afghanistan")
            {
                interactText.text = "Press E to send Agents to Afghanistan";

                if (hit.transform.tag == "Mar 1942")
                {
                    intel.text = " Country: Afghanistan \n Capital: Kabul \n Occupation: Neutral \n Likelyhood to get caught: High \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Jun 1945")
                {
                    intel.text = " Country: Afghanistan \n Capital: Kabul \n Occupation: Neutral \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "India")
            {
                interactText.text = "Press E to send Agents to India";

                if (hit.transform.tag == "Mar 1942")
                {
                    intel.text = " Country: India \n Capital: New Delhi \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Mar 1944")
                {
                    intel.text = " Country: India \n Capital: New Delhi \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Oct 1945")
                {
                    intel.text = " Country: India \n Capital: New Delhi \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Burma")
            {
                interactText.text = "Press E to send Agents to Burma";

                if (hit.transform.tag == "Dec 1942")
                {
                    intel.text = " Country: Burma \n Capital: Nay Pyi Daw \n Occupation: Axis Alliance \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Thailand")
            {
                interactText.text = "Press E to send Agents to Thailand";

                if (hit.transform.tag == "Dec 1942")
                {
                    intel.text = " Country: Thailand \n Capital: Bangkok \n Occupation: Axis Alliance \n Likelyhood to get caught: High \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "French Indochina")
            {
                interactText.text = "Press E to send Agents to the French Indochina";

                if (hit.transform.tag == "Dec 1942")
                {
                    intel.text = " Country: French Indochina \n Capital: Saigon \n Occupation: Axis Alliance \n Likelyhood to get caught: High \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Philippines")
            {
                interactText.text = "Press E to send Agents to the Philippines";

                if (hit.transform.tag == "Mar 1943")
                {
                    intel.text = " Country: Philippines \n Capital: Manila \n Occupation: Axis Alliance \n Likelyhood to get caught: High \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Sept 1945")
                {
                    intel.text = " Country: Philippines \n Capital: Manila \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Australia")
            {
                interactText.text = "Press E to send Agents to Australia";

                if (hit.transform.tag == "Mar 1943")
                {
                    intel.text = " Country: Australia \n Capital: Canberra \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "New Guinea")
            {
                interactText.text = "Press E to send Agents to New Guinea";

                if (hit.transform.tag == "Mar 1943")
                {
                    intel.text = " Country: New Guinea \n Capital: --- \n Occupation: Axis Alliance \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Japan")
            {
                interactText.text = "Press E to send Agents to Japan";

                if (hit.transform.tag == "Dec 1943")
                {
                    intel.text = " Country: Japan \n Capital: Tokyo \n Occupation: Axis Alliance \n Likelyhood to get caught: High \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Sept 1945")
                {
                    intel.text = " Country: Japan \n Capital: Tokyo \n Occupation: Allied Powers \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Korea")
            {
                interactText.text = "Press E to send Agents to Korea";

                if (hit.transform.tag == "Dec 1943")
                {
                    intel.text = " Country: Korea \n Capital: Keijo \n Occupation: Axis Alliance \n Likelyhood to get caught: High \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "Manchuria")
            {
                interactText.text = "Press E to send Agents to Manchuria";

                if (hit.transform.tag == "Dec 1943")
                {
                    intel.text = " Country: Manchuria \n Capital: Hsinking \n Occupation: Axis Alliance \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Mar 1945")
                {
                    intel.text = " Country: Manchuria \n Capital: Hsinking \n Occupation: Axis Alliance \n Likelyhood to get caught: High \n Status: \n \n ---";

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
            }

            else if (hit.transform.name == "China")
            {
                interactText.text = "Press E to send Agents to China";

                if (hit.transform.tag == "Mar 1944")
                {
                    intel.text = " Country: China \n Capital: Chongqing \n Occupation: Allied Powers \n Likelyhood to get caught: High \n Status: \n \n ---";

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

                else if (hit.transform.tag == "Aug 1945")
                {
                    intel.text = " Country: China \n Capital: Chongqing \n Occupation: Allied Powers \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
