using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inRedTrigger : MonoBehaviour
{
    AudioSource correctstuffyinTrigger;
    bool redtrigger;

    private void Start()
    {
        correctstuffyinTrigger = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "dreambunny")
        {

            redtrigger = true;

        }

        
        if (other.tag == "dreampuppy")
        {

            redtrigger = true;

        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "dreambunny")
        {

            redtrigger = false;

        }

        
        if (other.tag == "dreampuppy")
        {

            redtrigger = false;

        }
        
    }

  

    private void Update()
    {
        if (redtrigger == true && Input.GetKeyDown(KeyCode.Q))
        {
            correctstuffyinTrigger.Play();
        }
    }




}
