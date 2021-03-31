using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DropDownScript2 : MonoBehaviour
{
    public TextMeshProUGUI output;

    public GameObject textObject;

    // Start is called before the first frame update
    void Start()
    {
        textObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HandleInputData(int val)
    {
        if (val == 1)
        {
            textObject.SetActive(true);

            output.text = "Correct!";
        }

        else
        {
            textObject.SetActive(true);

            output.text = "Incorrect!";
        }
    }
}
