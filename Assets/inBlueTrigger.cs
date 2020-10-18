using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class inBlueTrigger : MonoBehaviour
{

    AudioSource correctstuffyinTrigger;
    bool blutrigger;

    private void Start()
    {
        correctstuffyinTrigger = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D pig)
    {
        
        if (pig.tag == "dreampig")
            {

            blutrigger = true;
               
            }
    }

    private void OnTriggerExit2D(Collider2D pig)
    {

        if (pig.tag == "dreampig")
        {

            blutrigger = false;

        }
    }

    private void Update()
    {
        if(blutrigger == true && Input.GetKeyDown(KeyCode.Q))
            {
                correctstuffyinTrigger.Play();
            }
    }




}
