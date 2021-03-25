using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleStateOfWar : MonoBehaviour
{
    public GameObject warCanvas;

    public bool warReveal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Toggle for State of War Box

        if (Input.GetKeyDown(KeyCode.W))
        {
            warReveal = !warReveal;

            if (warReveal)
            {
                //Debug.Log("warReveal is on!");

                warCanvas.SetActive(true);
            }

            else
            {
                //Debug.Log("warReveal is off!");

                warCanvas.SetActive(false);
            }
        }
    }
}
