using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGreenTrigger : MonoBehaviour
{
    AudioSource correctstuffyinTrigger;
    bool greentrigger;

    public int dreampoints;
    public Text DreamPointsText;

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

            dreampoints++;
            DreamPointsText.text = ("dream stuffies: " + dreampoints.ToString());
        }

    }




}
