using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPinkTrigger : MonoBehaviour
{
    AudioSource correctstuffyinTrigger;
    bool pinktrigger;

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

    private void OnTriggerExit2D(Collider2D chick)
    {

        if (chick.tag == "dreamchick")
        {

            pinktrigger = false;

        }
    }

    private void Update()
    {
        if (pinktrigger == true && Input.GetKeyDown(KeyCode.Q))
        {
            correctstuffyinTrigger.Play();
        }
    }




}
