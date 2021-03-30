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
                    intel.text = " Country: Taiwan \n Capital: Taihoku \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n ---";

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
                    intel.text = " Country: Taiwan \n Capital: Taihoku \n Occupation: Allies \n Likelyhood to get caught: High \n Status: \n \n ---";

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
                    "We recently got intel that something is happening to the Jewish people. This might be worth investigating...";

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
                    intel.text = " Country: Germany \n Capital: Berlin \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                        "accusations. The Prime Minister seemed very on edge in the brief interaction with one of our agents. Something big is coming.";

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
                    intel.text = " Country: Poland \n Capital: Warsaw \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: France \n Capital: Paris \n Occupation: Neutral \n Likelyhood to get caught: Low (5%) \n Status: \n \n French Spies are requesting a meeting. They are saying it is " +
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
                    intel.text = " Country: France \n Capital: Paris \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: Italy \n Capital: Rome \n Occupation: Neutral \n Likelyhood to get caught: High \n Status: \n \n Our relations unit has told us that Italy is currently committed to staying neutral. " +
                        "They seem to doubt that Prime Minister Mussolini will do anything rash, when most of their military equipment is still dated back to the Great War. However, seasoned General Wavell has stated before that " +
                        "Mussolini is an opportunist. We must tread carefully� If the spy is truly an enemy, perhaps they would go to a place of uncertainty�";

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
                    intel.text = " Country: Italy \n Capital: Rome \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Italy has been acting suspicious";

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
                    intel.text = " Country: Spain \n Capital: Madrid \n Occupation: Neutral \n Likelyhood to get caught: Low \n Status: \n \n Spain has declared they will remain neutral for the duration of this war. They just " +
                        "recently ended their civil war, with the Nationalists winning. They are in no place to help either side substantially. Although, perhaps this means it would be a good place to lay low�";

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
                    intel.text = " Country: Soviet Union \n Capital: Moscow \n Occupation: Allies \n Likelyhood to get caught: High \n Status: \n \n After the Axis Powers declared war, and attacked the Soviet Union, " +
                        "the Red Army formally joined the Allies, with the goal to drive back, and defeat Germany and its allies (With the exception of Japan as they signed a neutrality Pact). As of now, the Nazis are " +
                        "digging through the Soviet Union, making ground toward Moscow. However, The Red Army�s will to retaliate is far from gone. It is possible that our mole has made their way into the Soviet Union, " +
                        "but would it really be that obvious?";

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
                    intel.text = " Country: Soviet Union \n Capital: Moscow \n Occupation: Allies \n Likelyhood to get caught: High \n Status: \n \n ---";

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
                    intel.text = " Country: Sweden \n Capital: Stockholm \n Occupation: Neutral \n Likelyhood to get caught: Medium \n Status: \n \n Sweden declared a Neutral stance with regards to the war, and there seems " +
                        "to be no hint at the country changing their position. However, it seems that the Swedes are willing to play both sides of the war passively. They supplied Finland during the Winter War with supplies " +
                        "to fight the Soviet Union, including weapons and aircraft. We have also heard that Sweden cracked the German�s Geheimfernschreiber Cypher Machine, letting them know their military intentions. " +
                        "At the same time, Once the Germans attacked the Soviet Union, Sweden allowed the Nazis to go through their territory by train to reach the front lines faster. Sweden seems to be a perfect place " +
                        "for someone to learn about both the Allies and Axis Powers�";

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
                    intel.text = " Country: Finland \n Capital: Helsinki \n Occupation: Finland \n Likelyhood to get caught: Low \n Status: \n \n Finland seems to be in a similar position as Sweden, except they are openly " +
                        "hostile towards the Soviet Union. However, at the same time, it seems there is just a non-aggression pact between Germany and Finland, and they are not necessarily allies. They appear to be a " +
                        "wild card in this war. Both of Britain�s raids to support the Soviet Union have been largely unsuccessful against Finland. Perhaps there could be something going on behind the scenes in Finland�";

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
                    intel.text = " Country: Finland \n Capital: Helsinki \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: Great Britain \n Capital: London \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n After declaring war on Germany, Britain dispatched the " +
                        "BEF (British Expeditionary Force) to support France. Britain has also received three Modern Destroyers and two Submarines from Poland just before they fell, to strengthen the United Kingdom. " +
                        "Britain is gearing up for war. As for our spy, it may be a safe option to have agents search the archives and find out where this traitor may have gone to�";

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
                    intel.text = " Country: Great Britain \n Capital: London \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: Algeria \n Capital: Algiers \n Occupation: Allies \n Likelyhood to get caught: Medium \n Status: \n \n Algeria appears to currently be split between two groups. Those supporting the " +
                        "French and Allies, generally the Natives of the Country, and those seemingly supporting Nazi Germany, generally the colonists, or as the natives would call, pied noirs. We are unsure of what will come to " +
                        "Algeria, but when there is a spark, there is the possibility of a fire.";

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
                    intel.text = " Country: Libya \n Capital: Tripoli \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n Libya has recently been conquered by Italian forces, and appears to be the " +
                        "stronghold of the Axis Powers in Africa. There appears to be a mix of strong support from Muslim Libyans for the Italian Army, while there are scattered skirmishes throughout by the Savari and " +
                        "the Spahi trying to oust the Italians. As of right now, we would be hard-pressed to attempt a rebellion so quickly. But, perhaps the reason for such a stronghold is due to information gleaned by this spy�";

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
                    intel.text = " Country: Turkey \n Capital: Ankara \n Occupation: Neutral \n Likelyhood to get caught: Medium \n Status: \n \n Turkey has declared that they will remain Neutral, despite being met by both " +
                        "ambassadors from the Allies, as well as the Axis Powers. It makes some sense due to the last war they were in lasted 11 years (1911-1922), and brought great hardship on its civilians. " +
                        "President Inonu has stated that, despite their large standing army, they will not engage either side of the conflict. It is well known that they have received ambassadors from many countries, " +
                        "could the spy be involved?";

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
                    intel.text = " Country: Turkey \n Capital: Ankara \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: Egypt \n Capital: Cairo \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Egypt has cut all ties from the countries of the Axis Powers since the outbreak " +
                        "of the war. Egypt has served as a major base for the British in the pursuit of taking back Africa. Although Egypt assisted in defending its homeland, the ruler of Egypt, King Farouk, has said that " +
                        "outside of Egypt, they would not be participating in any conquests, angering our allies. Does the spy have something to do with King Farouk�s attitude?";

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
                    intel.text = " Country: Egypt \n Capital: Cairo \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: Romania \n Capital: Bucharest \n Occupation: Allies \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
                    intel.text = " Country: Saudi Arabia \n Capital: Riyadh \n Occupation: Neutral \n Likelyhood to get caught: Medium \n Status: \n \n Saudi Arabia is also somewhat of an enigma, declaring to be Neutral, " +
                        "but cutting off all ties with Germany. We�ve also heard from President Roosevelt, who is apparently a personal friend of King Abdul Aziz Al-Saud, that they will soon cut all diplomatic " +
                        "ties with Japan. We have also been fortunate enough to continue trading, receiving large amounts of oil. It may be possible that our spy could try to turn the tide on diplomacy�";

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
                    intel.text = " Country: Ethiopia \n Capital: Addis Ababa \n Occupation: Axis Powers \n Likelyhood to get caught: Medium \n Status: \n \n Ethiopia is currently occupied by Italian forces. There have been talks " +
                        "with Emperor Hailie Selassie about a resistance effort, but nothing has been solidified as of yet. As of now, it would be a semi-dangerous " +
                        "mission to send spies, but, perhaps it's worth the risk entering new enemy territory.";

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
                    intel.text = " Country: Sudan \n Capital: Khartoum \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Sudan is a staunch ally of the United Kingdom. With the SDF (Sudan Defence Force), " +
                        "we expect Sudan to be able to hold their ground in the case of an attack. However, they have expressed worry over Libya turning to Germany, and expressed they would not be in a position immediately to " +
                        "suppress this if the time came. Perhaps the spy came here to report to their master Africa�s situation?";

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
                    intel.text = " Country: Nigeria \n Capital: Abuja \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Nigeria has established the NWRF (Nigerian War Relief Fund), to gather volunteers to " +
                        "develop local support for Britain in the war. Support appears to be popular, and many have signed up to join the war effort. We appreciate the support, and will use it, but Britain is concerned that the " +
                        "Nigerians don�t fully understand the gravity of the situation�";

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
                    intel.text = " Country: Nigeria \n Capital: Abuja \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: Democratic Republic of the Congo \n Capital: L�opoldville \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n The Democratic Republic of the Congo is in an " +
                        "interesting predicament. They want to remain neutral in the conflict, against both Allies� and Axis Powers� wishes. Britain has refused the request, and a deal came about that all of the Congo�s raw " +
                        "materials would go to the Allies. As for manpower, it appears we will not be able to fully expect much. It appeared that the Congo had tried to contact Nazi Germany, attempting to " +
                        "appeal to neutrality� Perhaps the spy has something to do with it?";

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
                    intel.text = " Country: Yemen \n Capital: Sana'a \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Northern Yemen seems to be following an Isolationist Foreign Policy through the " +
                        "war under King Yahya Muhammad Hamid ed-Din. Half of the country is allied with Italy (Albeit the alliance was made in 1936, four years prior to the start of the war), and the other " +
                        "half, Aden Protectorate, is under British control. Although the half that is under British control supports the war cause, as of yet, they have done nothing for us to solidify this. " +
                        "They have acted like a Neutral country since the beginning, and they are showing no signs of changing course. It is unknown what the spy would be doing in Yemen, but perhaps because it " +
                        "is unknown, that is precisely the reason they could be there�";

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
                    intel.text = " Country: Afghanistan \n Capital: Kabul \n Occupation: Neutral \n Likelyhood to get caught: High \n Status: \n \n Afghanistan has sustained neutrality in the war thus far. However, " +
                        "our informants have told us that there have been talks between Afghanistan and Germany, asking if they can have some of British India territory should they win the war. Despite pressure from the " +
                        "Allies, Afghanistan is sustaining this friendly relationship. So far, Afghanistan has made no moves toward either side, and so until they do, it would be in our interest to let them stay Neutral. " +
                        "It has also come to our attention that the former King of Afghanistan, Amanullah Khan, is working as an agent of Nazi Germany, with the goal of gaining help from the Nazis to regain his throne. " +
                        "Perhaps this is why Afghanistan is staying friendly� Regardless, it is very possible that our mole would be mettling with Afghanistan. Any country would want Afghanistan as their own. If anytime " +
                        "was the right time to scout out the area, it would be now.";

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
                    intel.text = " Country: India \n Capital: New Delhi \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n British India declared war on the Axis Powers the same time as Britain, " +
                        "and so far, has been one of the greatest assets we could have asked for. We are currently looking at ways to take back Africa, and they will be an invaluable asset to achieve this goal. " +
                        "However, it seems that India is very divided on their current status as a pawn of Britain. We believe that Indian Independence is unnecessary in the pursuit of defeating the Axis Powers, " +
                        "and have elected to ignore the request. Talks like that can come later, if, they come back� As for if the spy is here, it is possible. We believe that Japan will be turning its head towards " +
                        "India soon, so this could be a preliminary to what�s to come.";

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
                    intel.text = " Country: India \n Capital: New Delhi \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: India \n Capital: New Delhi \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: Burma \n Capital: Nay Pyi Daw \n Occupation: Axis Powers \n Likelyhood to get caught: Medium \n Status: \n \n Japanese forces have defeated the joint forces of China and " +
                        "Britain and conquered the British colony of Burma. Due to Japan rapidly reinforcing their hold of Burma with the help of their new ally, Thailand, British had to leave Burma and return to India. " +
                        "Now under the strict thumb of Japan, the colony now serves as a hub for continuing Japanese expansion towards India and beyond.";

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
                    intel.text = " Country: Thailand \n Capital: Bangkok \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n Due to Japan using Thailand as a foothold to invade Burma, " +
                        "Allies retaliated and bombed Bangkok, the capital of Thailand. In retaliation, Thailand declared war on the Allies, and officially allied themselves with Japan. However, in September, " +
                        "great floods plagued Thailand, destroying much of the rice fields in the country. Instead of Rice, the Thai government told its civilians to eat noodles instead. We believe that it is " +
                        "possible the spy made its way to Thailand in order to learn more about the situation in the East, or perhaps they were there to try out the new �Pad Thai� Thailand had come up with�";

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
                    intel.text = " Country: French Indochina \n Capital: Saigon \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n As soon as France was defeated by Germany, French Indochina " +
                        "was controlled by the German-backed Vichy government. Once the Japanese came and occupied the region, there was little to no resistance. We�ve seen no notion of any resistance in the French Colony, " +
                        "and due to it being behind Burma at this time, there is no way for us to liberate them anytime soon without first making ground on Burma. However, we have heard of a curious fellow named Ho Chi Minh, " +
                        "setting seeds for a Communist Revolution. Perhaps the spy may be involved?";

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
                    intel.text = " Country: Philippines \n Capital: Manila \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n ---";

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
                    intel.text = " Country: Philippines \n Capital: Manila \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: Australia \n Capital: Canberra \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: New Guinea \n Capital: --- \n Occupation: Axis Powers \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
                    intel.text = " Country: Japan \n Capital: Tokyo \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n ---";

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
                    intel.text = " Country: Japan \n Capital: Tokyo \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n ---";

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
                    intel.text = " Country: Korea \n Capital: Keijo \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n ---";

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
                    intel.text = " Country: Manchuria \n Capital: Hsinking \n Occupation: Axis Powers \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
                    intel.text = " Country: Manchuria \n Capital: Hsinking \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n ---";

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
                    intel.text = " Country: China \n Capital: Chongqing \n Occupation: Allies \n Likelyhood to get caught: High \n Status: \n \n ---";

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
                    intel.text = " Country: China \n Capital: Chongqing \n Occupation: Allies \n Likelyhood to get caught: Medium \n Status: \n \n ---";

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
