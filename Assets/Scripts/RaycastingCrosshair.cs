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
                    intel.text = " Country: Taiwan \n Capital: Taihoku \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n Despite Taiwan’s deep past with China, Japan seems to have ingrained " +
                        "itself deeply into the social lives of Taiwan. The Japanese have fully utilized Taiwan’s material resources in the war effort, and persuaded a large amount of Taiwanese to join the war " +
                        "effort throughout the war thus far. It appears that out of all Japanese strongholds, Taiwan is one of the strongest.";

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

                            report.text = "Once the spy entered Taiwan, they seemed to have disappeared with the wind. They definitely did not seem to be allied with the Taiwanese, " +
                                "but they certainly seemed like they had a place to go. However, as we were searching undercover, we got a message from French Resistance that the spy has been spotted in Europe.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Oct 1945")
                {
                    intel.text = " Country: Taiwan \n Capital: Taihoku \n Occupation: Allies \n Likelyhood to get caught: High \n Status: \n \n Taiwan is the last territory to be given up by the " +
                        "Japanese to China on October 25th, 1945. The country suffered many losses from the war, including many youths who served in Japan’s army, as well many bombing runs on the " +
                        "country throughout the war. Much of the Taiwanese Communist Party seemed to escape into the CCP once Taiwan was seized by China after the war. It appears surface level that " +
                        "Taiwan is in no position at this point to do anything substantial…";

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

                            report.text = "We tracked the spy all the way to Taiwan, this time, with more forces in tow. Just as we finally got the drop on and surrounded them, the spy spoke nothing, but smiled. " +
                                "He quickly pulled a pistol out, and before we could stop them, they fired, ending their own life. On their corpse, we found nothing that could be of any use for evidence. " +
                                "However, it is clear that Taiwan was their final resting place, and base of operations after finding a secret bunker behind a cliff.";
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

                            report.text = "It appears that a vague communication was made with a Nation that just got out of a Civil War. It is signed with an R.A. It might be worth it to check it out…";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Aug 1945")
                {
                    intel.text = " Country: Germany \n Capital: Berlin \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Now that Germany has been completely defeated, " +
                        "and much of the world turns to Japan, perhaps now might be a good time to see if this mole has any connections within Berlin…";

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

                            report.text = "It appears the spy staked out in Western Germany, and met with others. Unfortunately, we were unable to make out their identities. " +
                                "They shook hands at the end of the meeting, and it seems they are heading back into Asia…";
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

                            report.text = "As the meeting with the Prime Minister progressed, it’s clear that Germany’s intent is to conquer Poland. However, the Prime Minister also hinted that " +
                                "something else may be lurking in the shadows behind the Nazi invasion. There was no mention of any spy here…";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Aug 1945")
                {
                    intel.text = " Country: Poland \n Capital: Warsaw \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Poland has suffered terribly in this World War. From deportation and execution " +
                        "of the Jewish people, the largest demographic of Poland. It’s no surprise when the time to strike back against Germany, they had the fourth largest army in the world attacking Nazi Germany. " +
                        "It will take years, decades, perhaps even a Century, to recoup the losses of their people…";

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

                            report.text = "Due to Poland’s current dilemma, and the travesties it has endured, they have seen nothing of the spy. It is unfortunate, but forgivable, considering…";
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

                            report.text = "French Spies report that a mysterious individual just traveled from Britain and through France, toward Spain. This might be a lead on the mole…";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Mar 1945")
                {
                    intel.text = " Country: France \n Capital: Paris \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Now that France is finally rid of the German War Machine, we are finally back " +
                        "in full contact with French Spies. The First French Army is preparing to help with the invasion of Western Germany. Although exhausted from leading the French Resistance during their occupation, " +
                        "French spies are continuing monitoring the mole situation. They’ve reached out to us that they have some information that may be useful in figuring out the allegiance of our mole problem.";

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

                            report.text = "As soon as the spy caught on that they’d been found out, they fled Eastward once again. In their rush, they appeared to drop a Chess Piece, a King, out of their pocket.";
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
                        "Mussolini is an opportunist. We must tread carefully… If the spy is truly an enemy, perhaps they would go to a place of uncertainty…";

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

                            report.text = "Unfortunately, it appears the Spy has not been to Italy recently. There have been no tracks here regarding the mole. It is unknown where they might have gone...";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Jun 1945")
                {
                    intel.text = " Country: Italy \n Capital: Rome \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Italy is no longer a threat to the Allies, and from what we’ve been told, " +
                        "they are set to declare war on Japan. Former Prime Minister Mussolini was also killed Italian Communists. We may be able to find some hints to our mole here…";

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

                            report.text = "Although the spy was not spotted in Italy, we have found clues from the Italian Communists, that perhaps our mole may be once again heading to Europe, " +
                                "into the heart of the destroyed War Machine.";
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
                        "recently ended their civil war, with the Nationalists winning. They are in no place to help either side substantially. Although, perhaps this means it would be a good place to lay low…";

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

                            report.text = "Spain has determined that they are not going to risk their Neutrality with working with us too much. However, behind closed doors, a governmental worker " +
                                "said they saw the person’s suitcase as they boarded a train. It said, “Sudan.”";
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
                        "digging through the Soviet Union, making ground toward Moscow. However, The Red Army’s will to retaliate is far from gone. It is possible that our mole has made their way into the Soviet Union, " +
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

                            report.text = "Although the Red Army is on our side in the war, it appears that they have no info on the spy… to share. One of our spies managed to swipe a document " +
                                "out of the office we were in. It seemed to detail potential spywork in Afghanistan and Yemen. We are still unsure whether the spy is affiliated with the Soviets, " +
                                "but this may be a good place to start.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Mar 1944")
                {
                    intel.text = " Country: Soviet Union \n Capital: Moscow \n Occupation: Allies \n Likelyhood to get caught: High \n Status: \n \n The Soviets are pushing hard towards Germany right now. We’ve been " +
                        "working closer than ever with Stalin and the Red Army to finally rid the war of the Germans. However, it does feel like they are still keeping much behind closed doors. " +
                        "Perhaps the mole knows something we don’t…";

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

                            report.text = "As before, the Soviets kept the possibility of a spy close to the chest, and gave no leeway. " +
                                "It is certain they are hiding something, but we don’t know at this point just how much…";
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
                        "to fight the Soviet Union, including weapons and aircraft. We have also heard that Sweden cracked the German’s Geheimfernschreiber Cypher Machine, letting them know their military intentions. " +
                        "At the same time, Once the Germans attacked the Soviet Union, Sweden allowed the Nazis to go through their territory by train to reach the front lines faster. Sweden seems to be a perfect place " +
                        "for someone to learn about both the Allies and Axis Powers…";

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

                            report.text = "It seems that the spy stayed in Sweden for quite a long time avoiding us. We finally found the cabin they had stayed in, and it seemed to us that they very " +
                                "much enjoyed the game of chess…";
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
                        "wild card in this war. Both of Britain’s raids to support the Soviet Union have been largely unsuccessful against Finland. Perhaps there could be something going on behind the scenes in Finland…";

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

                            report.text = "It appears that Finland wants nothing to do with us. Both times, Finland has told us to stay out… or else. We took the warning seriously as anything more may jeopardize the mission.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Oct 1945")
                {
                    intel.text = " Country: Finland \n Capital: Helsinki \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n It seems as though Finland is going to be deemed an ally of Nazi Germany " +
                        "in the war, and will be subject to bear responsibility with the other Axis Powers  for the war reparations. It is unclear at this point what this means exactly for Finland, " +
                        "and it is projected that it will be a year or so before agreements can be made.";

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

                            report.text = "Unfortunately, the spy did not come to Finland. We have lost all sights of them, and it is clear they have no affiliation with Finland.";
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
                        "Britain is gearing up for war. As for our spy, it may be a safe option to have agents search the archives and find out where this traitor may have gone to…";

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

                            report.text = "Reading into the archives and files, we’ve found fifteen individuals who’ve all retired in the last three years. There have been no retirees since then, " +
                                "and so we can rule out all current agents. Curiously, on seven of their files, we have listed that they have ties to the SDF. It’s a long shot, but it may be a place to start…";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Dec 1944")
                {
                    intel.text = " Country: Great Britain \n Capital: London \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n With the liberation of France, Britain now finally has a good " +
                        "distance from the Nazis. Although, at this point, the Axis Powers’ defeat is imminent! It may be worth checking if anything new has been dug up out of the archives about our mole problem…";

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

                            report.text = "After once again, rummaging through the archives, we’ve found some more information about this mole. " +
                                "It appears their entire document had been scratched out prior to their retirement. It is shameful that we let this happen… " +
                                "However, we can tell that the country was at least two words long. We have also just received a report from French Resistance, that the spy has been spotted nearby.";
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

                            report.text = "It appears that the spy may have come through Algeria, but it is uncertain where they may have gone afterwards. In a bar, some locals saw me distressed, " +
                                "and gave the sage advice, “Perhaps it's best to keep your enemies close, but your friends closer.” I don’t think this is how that advice goes, but I’ll take it to heart.";
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
                        "the Spahi trying to oust the Italians. As of right now, we would be hard-pressed to attempt a rebellion so quickly. But, perhaps the reason for such a stronghold is due to information gleaned by this spy…";

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

                            report.text = "It appears that the spy was in fact here. They escaped before we could close in. We’ve gotten reports that they are going to a " +
                                "location that has thus far maintained Neutrality towards both sides of the war.";
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

                            report.text = "We just missed the spy. However, they seemed to have traveled with ease through the Soviet Union. But, they did not stop there. " +
                                "It seems that they may have stopped at a “Neutral” country.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Jun 1945")
                {
                    intel.text = " Country: Turkey \n Capital: Ankara \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Turkey, despite maintaining Neutrality throughout the entire war, " +
                        "has joined the Allies against the Japanese Empire. However, it appears despite such a declaration, they have no plans to help with the invasion. Worthless…";

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

                            report.text = "We learned nothing from Turkey. They first remained Neutral in this war of conquest waged by the Nazis, and then they finally decided to join the Allies against Japan, " +
                                "and then plan to do nothing besides the formal declaration… And now they say they know nothing of the spy… Director, I must ask that you speak to C. about this. It is disgraceful.";
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
                        "outside of Egypt, they would not be participating in any conquests, angering our allies. Does the spy have something to do with King Farouk’s attitude?";

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

                            report.text = "Staying as true as Egypt says, they are not cooperating with finding said spy. We are in the dark whether the spy stopped here or not…";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Dec 1944")
                {
                    intel.text = " Country: Egypt \n Capital: Cairo \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Egypt has continued being a part of the Allies, but has still refused to assist in " +
                        "greater lengths with the war effort. British command is furious, but at this stage in the war, there is nothing that can really be done…";

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

                            report.text = "We learned no more valuable information from Egypt. The only saving grace of this mission is that French Resistance has notified us that the spy has been spotted in Europe again.";
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
                    intel.text = " Country: Romania \n Capital: Bucharest \n Occupation: Allies \n Likelyhood to get caught: Medium \n Status: \n \n It took a coup to dislodge Romania from the Axis Powers. " +
                        "It’s likely that they would have been taken over swiftly by the Red Army anyways, but, at least in this sense, King Michael I saved Romania mostly from a costly invasion. Even so, " +
                        "Romania still lost a significant portion of its army to the Soviets. They have declared war on Nazi Germany, and almost immediately after, Romania took the fight to Hungary, one of " +
                        "Germany’s last allies in Europe. We may be able to glean information about the spy here as it is in the middle of three different conflicts…";

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

                            report.text = "It seems that the Spy has passed through Romania recently, and is continuing Eastward.";
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
                        "but cutting off all ties with Germany. We’ve also heard from President Roosevelt, who is apparently a personal friend of King Abdul Aziz Al-Saud, that they will soon cut all diplomatic " +
                        "ties with Japan. We have also been fortunate enough to continue trading, receiving large amounts of oil. It may be possible that our spy could try to turn the tide on diplomacy…";

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

                            report.text = "The spy has definitely stopped here, but did not stay long. King Abdul Aziz Al-Saud has said he received a report a " +
                                "few weeks ago regarding a non-native traveling out of the country, going northward.";
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

                            report.text = "Unfortunately, there have been no sightings of the spy in Ethiopia, and the Emperor has said there have been no reports on his side. All we can do is trust him, and continue searching on…";
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
                        "suppress this if the time came. Perhaps the spy came here to report to their master Africa’s situation?";

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

                            report.text = "Just as we have caught up, it appears that the spy left, presumably to a country controlled by the Axis Powers. If they wanted to get some distance from us, " +
                                "it makes sense for them to get to the most heavily fortified area.";
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
                        "Nigerians don’t fully understand the gravity of the situation…";

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

                            report.text = "Unfortunately, besides getting some relief from the NWRF, there have been no signs of the spy. We are in the dark where they may have gone next.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Sept 1945")
                {
                    intel.text = " Country: Nigeria \n Capital: Abuja \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Nigeria played a critical role with India in expelling " +
                        "Japanese forces from Burma prior to Japan’s eventual surrender.";

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

                            report.text = "Despite Nigeria playing an important role in expelling the Japanese, it is clear that the spy is not here.";
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
                    intel.text = " Country: Democratic Republic of the Congo \n Capital: Léopoldville \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n The Democratic Republic of the Congo is in an " +
                        "interesting predicament. They want to remain neutral in the conflict, against both Allies’ and Axis Powers’ wishes. Britain has refused the request, and a deal came about that all of the Congo’s raw " +
                        "materials would go to the Allies. As for manpower, it appears we will not be able to fully expect much. It appeared that the Congo had tried to contact Nazi Germany, attempting to " +
                        "appeal to neutrality… Perhaps the spy has something to do with it?";

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

                            report.text = "The Democratic Republic of the Congo is in an interesting predicament. They want to remain neutral in the conflict, against both Allies’ and Axis Powers’ wishes. " +
                                "Britain has refused the request, and a deal came about that all of the Congo’s raw materials would go to the Allies. As for manpower, it appears we will not be able to fully " +
                                "expect much. It appeared that the Congo had tried to contact Nazi Germany, attempting to appeal to neutrality… Perhaps the spy has something to do with it?";
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
                        "is unknown, that is precisely the reason they could be there…";

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

                            report.text = "We believe the spy made their way through Yemen, although, it is uncertain what their goal was here. It seems that the country " +
                                "the spy went to next just recently declared war on the United Kingdom and the United States.";
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
                        "Perhaps this is why Afghanistan is staying friendly… Regardless, it is very possible that our mole would be mettling with Afghanistan. Any country would want Afghanistan as their own. If anytime " +
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

                            report.text = "Our scouts have reported that the spy we’ve been tracking has scouted out Afghanistan, but, not been in contact with the Government. " +
                                "In a scrap of paper left behind in the mole’s camp, only three words were legible, ‘Italy of Asia.’";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Jun 1945")
                {
                    intel.text = " Country: Afghanistan \n Capital: Kabul \n Occupation: Neutral \n Likelyhood to get caught: Medium \n Status: \n \n Afghanistan is also no threat at this point in the war, and " +
                        "they’ve maintained their neutrality throughout this conflict, and we have no reason to believe they will change course. Since the battle of Stalingrad, there have been no mention of previous " +
                        "plans to take land from British India, nor from the former King Amanullah Khan trying to regain his throne. However, it is odd that nothing has come to Afghanistan during the war. Perhaps there " +
                        "is something bigger happening behind the scenes…";

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

                            report.text = "The spy once again returned to Afghanistan, presumably to survey the land. However, we were unable to find out much more as the spy found out we’d been " +
                                "following them. Quickly, they fled North-West through the expansive region of the Soviet Union. Although, it appears they did not stop in Russia… Perhaps they went " +
                                "to the end of the Soviet’s European conquest?";
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
                        "and have elected to ignore the request. Talks like that can come later, if, they come back… As for if the spy is here, it is possible. We believe that Japan will be turning its head towards " +
                        "India soon, so this could be a preliminary to what’s to come.";

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

                            report.text = "Unfortunately, it seems that there is no trace of the spy in India, and so we can conclude that they have not much in stake with India as of the moment.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Mar 1944")
                {
                    intel.text = " Country: India \n Capital: New Delhi \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Along with Sudan, India has helped to liberate the rest of Africa, " +
                        "and are currently a major part of the force invading Italy! However, their war still rages on against the Japanese in Burma. It has also been noted that there is a splinter group of the " +
                        "army that split off from British India, calling themselves, the Indian National army, is helping the Japanese fight against us. So far, British India has done a good job at repelling them, " +
                        "and unfortunately, we have no additional resources to spare to aid them. They will have to wait out until Germany is defeated, or until the Japanese give up Burma.";

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

                            report.text = "Upon checking in India again for the possibility of our mole, we have concluded that they did not come this way… again. We have nothing else to report.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Oct 1945")
                {
                    intel.text = " Country: India \n Capital: New Delhi \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n India is celebrating the Allies victory over the Axis Powers. " +
                        "What is concerning however, is the resurgence of the Quit India Movement, albeit under a different name, their goal is Independence from Britain… Perhaps it is about time.";

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

                            report.text = "Well, despite seeing him on the Southern Coastline of Asia, it appears that the spy did not travel into India. There is more than one country on the Southern Coastline of Asia.";
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

                            report.text = "Unfortunately, it seems that if the spy did go through Burma, they left no trace of stopping anywhere specific. We imagine they are going to the Pacific.";
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
                        "possible the spy made its way to Thailand in order to learn more about the situation in the East, or perhaps they were there to try out the new ‘Pad Thai’ Thailand had come up with…";

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

                            report.text = "It appears that the spy left Thailand in a hurry towards the Pacific. It seems that the forces stationed within Thailand were unaware of the " +
                                "spy within their ranks. But, from looking at the ship they stowed away on, we believe they are going towards the fighting in the Pacific, most likely where many U.S. bases are located…";
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
                        "was controlled by the German-backed Vichy government. Once the Japanese came and occupied the region, there was little to no resistance. We’ve seen no notion of any resistance in the French Colony, " +
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

                            report.text = "It looks like the spy did not stay long in the territory of French Indochina. But, it appears they did meet briefly with a man named Ho Chi Minh. " +
                                "The purpose of this meeting is unknown at the time, but the last we saw of them, the spy was heading towards Thailand, mostly likely to board a ship going to the Pacific.";
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
                    intel.text = " Country: Philippines \n Capital: Manila \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n The Philippines are staunch allies of the United States, and " +
                        "contained many important military bases for the U.S. Since early December, 1941, the Philippines have been a major site of Japanese conquest in the Pacific, mostly to delay and weaken the " +
                        "United States’ response to Japanese Imperialism in the war. Much of the warfare thus far in the war have been fought with guerilla tactics, and the combat has been brutal. It is possible that " +
                        "this spy may be moving around from island to island, looking for something…";

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

                            report.text = "We finally got a good look at the spy. They were tall, and with a broad build. But, as we managed to catch up, they spoke quickly, in what sounded like a " +
                                "raspy Russian accent. Before we could question them, they managed to escape onto a Japanese vessel without alerting the Japanese. It appears that they are on their way to Asia. " +
                                "Asking around, it seemed that it was on course to pick up more of what the Japanese called, ‘Comfort Women.’";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Sept 1945")
                {
                    intel.text = " Country: Philippines \n Capital: Manila \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n With Japan surrendering, much of the Japanese Empire’s forces are " +
                        "moving out of the Philippines. There are few groups holding onto resistance, but overall, it appears that they are largely isolated. Now that the Philippines is liberated, perhaps now would " +
                        "be the time to see if this spy appeared in the Pacific theater.";

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

                            report.text = "We do not believe the spy has come back to the Philippines, however, we have been notified that they were last spotted on the Southern Coastline of Asia…";
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
                    intel.text = " Country: Australia \n Capital: Canberra \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n Luckily, so far in the course of the war, there has been no fighting " +
                        "on the mainland of Australia. Australia has been a great ally to the British Commonwealth being a Colony and helping to fight the Germans early in the war. Since the Japanese conquest expanded " +
                        "towards Australia, it and the United States changed focus on the Pacific Theater with the goal to drive back the Japanese. As per our informants, we believe that Australia is currently mounting " +
                        "an offensive on New Guinea, and has already taken parts of it back for the Allies. It may be likely the mole could be working to gather information about a Colony who has yet to see any war on " +
                        "the mainland, despite being a part of the Allies.";

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

                            report.text = "A report from the Front lines in the Pacific Theater suggest that a person, not affiliated with Japan, nor ourselves, has been island hopping. When approached, " +
                                "the man ignored and did not speak. Before we could capture them, they escaped onto a Japanese vessel without alerting the Japanese. It seems that the boat is heading back to Asia, " +
                                "presumably to a stronghold of the Japanese.";
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
                    intel.text = " Country: New Guinea \n Capital: --- \n Occupation: Axis Powers \n Likelyhood to get caught: Medium \n Status: \n \n New Guinea has been a hot spot in the Pacific Theater alongside " +
                        "the Philippines for Japanese conquest. So far, the main problem the Allies have faced since Japanese occupation, is with the city of Rabaul. It overlooks a major harbor of New Guinea, and " +
                        "has many natural barriers. It is also ideal as an air base, and with Japanese fortifications, New Guinea has become a sturdy fortress. Much of the Japanese command for the Pacific Theater come " +
                        "from the city of Rabaul. There are currently talks about the best way to go about taking New Guinea back, and so far, the best option we’ve heard is to neutralize, and lay siege as opposed to " +
                        "capturing. New Guinea may be largely controlled by the Japanese, but Australia has taken back parts of it. It would be interesting if the spy were to have turned up here…";

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

                            report.text = "Unfortunately, with the amount of fighting in New Guinea, we were hard pressed to find any information on this spy. However, we can say that it is probably likely " +
                                "the mole did not stay in the Pacific for very long, and more than likely traveled back to Asia…";
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
                    intel.text = " Country: Japan \n Capital: Tokyo \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n We do not have very much information as of now about the mainland " +
                        "of Japan. At this point, we believe that Japan is on the path to overextending, so perhaps in the future, we may be able to glean something more. If there was a place the spy wanted to go " +
                        "to get away, it would be Japan, that’s if they were allied with them. Otherwise, they would be in serious trouble making it there…";

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

                            report.text = "The spy did not come to Japan. Chances are, it was too much of a risk for them. We barely got lucky enough to make it out without being spotted…";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Sept 1945")
                {
                    intel.text = " Country: Japan \n Capital: Tokyo \n Occupation: Allies \n Likelyhood to get caught: Low \n Status: \n \n On this day, September 2nd, 1945, Japan has signed the final papers to " +
                        "formally surrender to the Allies. A joyous day! With the dropping of the two  atomic bombs on Hiroshima and Nagasaki, the Japanese resistance is crippled. Even its citizens, who were all ready to " +
                        "fight at a moment's notice, are demoralized. If we are to get any information out of Japan about this mole, now is the time…";

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

                            report.text = "Since the surrender of Japan, infiltration has never been easier. We see that the spy did indeed come here. Although, before they did anything, " +
                                "they noticed they were being followed, and fled out of the country. At this point, it seems their only safe place left is the last place that has yet to be given over to the Allies…";
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
                    intel.text = " Country: Korea \n Capital: Keijo \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n Currently, Korea is under control of the Japanese " +
                        "Empire. Unfortunately, many of our informants were unable to make it back as Japan has an iron grip on the country. We do know that Korea’s Government-in-exile is located in " +
                        "Shanghai, China, and is working with the Chinese to take back Korea. As of yet, we believe this has largely been unfruitful. It is highly possible that the mole may be in the area, but we are unsure.";

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

                            report.text = "The spy has certainly been here undercover. As for the reason, we are still unsure. However, we do know that they left soon after, " +
                                "leaving behind evidence suggesting they are going to a Communist Country.";
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
                    intel.text = " Country: Manchuria \n Capital: Hsinking \n Occupation: Axis Powers \n Likelyhood to get caught: Medium \n Status: \n \n Manchuria was invaded, and annexed into Japanese territory " +
                        "all the way back in 1931. Since then, their government has been in exile in China, and was one of the major reasons for war between China and Japan breaking out much earlier than the start of " +
                        "this current world war. We’ve seen the reports and pictures of the Japanese bombing civilians, and shooting survivors. The Japanese are despicable in their conquests…";

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

                            report.text = "The spy did stop briefly in Manchuria. It seems that it was taking a look at Japan’s Kwantung Army, the largest standing Army Japan currently has. " +
                                "The spy left soon after, heading South-West.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Mar 1945")
                {
                    intel.text = " Country: Manchuria \n Capital: Hsinking \n Occupation: Axis Powers \n Likelyhood to get caught: High \n Status: \n \n Japan’s only border between them and the Soviet Union. " +
                        "Manchuria was taken over by Japan in desperation during the Great Depression of the 1920s. Manchuria served as a lifeline to Japan during this time period… As per the Yalta Conference, " +
                        "the Soviets are on track to declare war soon after Germany is defeated. If we had to guess, Manchuria will be the first to be conquered. Currently, Manchuria houses one of Japan’s largest armies. " +
                        "We would be hard pressed getting any information out of here safely.";

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

                            report.text = "The spy did not return to Manchuria, and it seems there was no point in coming back.";
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
                    intel.text = " Country: China \n Capital: Chongqing \n Occupation: Allies \n Likelyhood to get caught: High \n Status: \n \n The Second Sino-Japanese War broke out in 1937. Tensions had been " +
                        "high since the taking of Manchuria in 1931. China prior to the war had been allies with the Soviet Union, and so received much aid for the fight. Once China joined the full war as a member " +
                        "of the Allies, they received the full support of the United States against the Japanese. Japan has been clawing their way through China, and making some ground, but thus far, the Chinese are " +
                        "standing their ground more inland. Despite being allies, the current majority ruling government within are Communist, and so they have been largely uncooperative in ways with the British " +
                        "outside of fighting the Japanese…";

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

                            report.text = "It is certain the spy came to China. It seemed they were traveling more South, almost back to the Pacific, but not quite. " +
                                "They seemed to sneak a lot more carefully than they have for the past four years.";
                        }

                        levelLoader.GetComponent<LevelLoader>().LoadNextLevel();
                    }
                }

                else if (hit.transform.tag == "Aug 1945")
                {
                    intel.text = " Country: China \n Capital: Chongqing \n Occupation: Allies \n Likelyhood to get caught: Medium \n Status: \n \n It didn’t take long after the Soviets destroyed Japan’s main fighting " +
                        "force, and the United States dropped the two atomic bombs, for Japan to surrender, and finally after eight long years, the Second Sino-Japanese War came to a close. China so far has shown its " +
                        "military might, and it appears that it will be a world power once the dust and ash settles. However, China is on the verge of a full-country civil war, and so we are unsure of what the result of " +
                        "such a conflict will be. We sincerely hope the Nationalists party comes out victorious, but, it is unlikely due to the party suffering the most casualties fighting against Japan. " +
                        "The CCP (Communist Party of China) appears stronger than ever…";

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

                            report.text = "Returning to China, we’ve seen reports from the Chinese Nationalists that a Communist has snuck through, and is continuing Eastward in Asia.";
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
