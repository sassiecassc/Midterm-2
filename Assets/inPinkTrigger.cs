﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inPinkTrigger : MonoBehaviour
{
    AudioSource correctstuffyinTrigger;
    bool pinktrigger;

    public dreamLevelPoints dreamLevelPoints;

    private void Start()
    {
        correctstuffyinTrigger = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D chick)
    {

        if (chick.tag == "dreamchick")
        {

            pinktrigger = true;

        }
    }

    private void OnTriggerExit2D(Collider2D kitty)
    {

        if (kitty.tag == "dreamchick")
        {

            pinktrigger = false;

        }
    }

    private void Update()
    {
        if (pinktrigger == true && Input.GetKeyDown(KeyCode.Q))
        {
            correctstuffyinTrigger.Play();

            dreamLevelPoints.IncreasePoints();

            pinktrigger = false;
        }
        
    }




}
