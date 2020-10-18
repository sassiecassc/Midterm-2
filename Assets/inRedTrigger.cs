using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inRedTrigger : MonoBehaviour
{
    AudioSource correctstuffyinTrigger;
    bool redtrigger;

    public int dreampoints;
    public Text DreamPointsText;

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

            dreampoints++;
            DreamPointsText.text = ("dream stuffies: " + dreampoints.ToString());
        }
    }




}
