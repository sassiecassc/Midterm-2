using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inYellowTrigger : MonoBehaviour
{

    AudioSource correctstuffyinTrigger;
    bool yellowtrigger;


    public dreamLevelPoints dreamLevelPoints;

    private void Start()
    {
        correctstuffyinTrigger = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D squirrel)
    {

        if (squirrel.tag == "dreamsquirrel")
        {

            yellowtrigger = true;

        }
    }

    private void OnTriggerExit2D(Collider2D squirrel)
    {

        if (squirrel.tag == "dreamsquirrel")
        {

            yellowtrigger = false;

        }
    }

    private void Update()
    {
        if (yellowtrigger == true && Input.GetKeyDown(KeyCode.Q))
        {
            correctstuffyinTrigger.Play();

            dreamLevelPoints.IncreasePoints();

            yellowtrigger = false;
        }
        
    }




}
