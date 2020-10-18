using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGreenTrigger : MonoBehaviour
{
    AudioSource correctstuffyinTrigger;
    bool greentrigger;

    public dreamLevelPoints dreamLevelPoints;

    private void Start()
    {
        correctstuffyinTrigger = GetComponent<AudioSource>();


    }

    private void OnTriggerEnter2D(Collider2D kitty)
    {

        if (kitty.tag == "dreamkitty")
        {

            greentrigger = true;

        }
    }

    private void OnTriggerExit2D(Collider2D kitty)
    {

        if (kitty.tag == "dreamkitty")
        {

            greentrigger = false;

        }
    }

    private void Update()
    {
        if (greentrigger == true && Input.GetKeyDown(KeyCode.Q))
        {
            correctstuffyinTrigger.Play();

            dreamLevelPoints.IncreasePoints();

            greentrigger = false;
        }
        
    }




}
