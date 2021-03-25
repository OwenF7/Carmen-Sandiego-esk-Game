using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DateAndSideUpdater : MonoBehaviour
{
    public GameObject gUI;

    public TextMeshProUGUI sides;

    public TextMeshProUGUI date;

    public TextMeshProUGUI reportText; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;

        //Debug.Log(currentSceneName); 

        if (currentSceneName == "Sept 1 1939")
        {
            date.text = " September 1, 1939";

            sides.text = " Sides: \n <color=#FF0000>Germany</color> \n <color=#0D00FF>Poland</color> \n <color=#FFFFFF>France</color> ";

            reportText.text = " "; 
        }

        else if (currentSceneName == "Dec 1 1939")
        {
            date.text = " December 1, 1939";

            sides.text = " Sides: \n <color=#FF0000>Germany</color> \n <color=#0D00FF>Allies</color> \n <color=#D41338>Soviet Union</color> \n <color=#FF00D9>Finland</color>" +
                " \n <color=#7BE558>China</color> \n <color=#EAD830>Japanese Empire</color> ";

            reportText.text = " Press R to toggle Mission Report";
        }

        else if (currentSceneName == "Jun 1 1940")
        {
            date.text = " June 1, 1940";

            sides.text = " Sides: \n <color=#FF0000>Germany</color> \n <color=#0D00FF>Allies</color> \n <color=#D41338>Soviet Union</color> \n <color=#FF00D9>Finland</color>" +
                " \n <color=#7BE558>China</color> \n <color=#EAD830>Japanese Empire</color> ";

            reportText.text = " Press R to toggle Mission Report";
        }

        else if (currentSceneName == "Sept 1 1940")
        {
            date.text = " September 1, 1940";

            sides.text = " Sides: \n <color=#FF0000>Germany</color> \n <color=#0D00FF>Allies</color> \n <color=#D41338>Soviet Union</color> \n <color=#FF00D9>Finland</color>" +
                " \n <color=#7BE558>China</color> \n <color=#EAD830>Japanese Empire</color> ";

            reportText.text = " Press R to toggle Mission Report";
        }
    }
}
