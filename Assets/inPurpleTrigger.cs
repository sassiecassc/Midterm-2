using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inPurpleTrigger : MonoBehaviour
{

AudioSource correctstuffyinTrigger;
bool purpletrigger;

    public int dreampoints;
    public Text DreamPointsText;

    private void Start()
{
    correctstuffyinTrigger = GetComponent<AudioSource>();
}

private void OnTriggerEnter2D(Collider2D other)
{

    if (other.tag == "dreamfox")
    {

        purpletrigger = true;

    }


    if (other.tag == "dreamwolf")
    {

        purpletrigger = true;

    }

}

private void OnTriggerExit2D(Collider2D other)
{

    if (other.tag == "dreamfox")
    {

        purpletrigger = false;

    }


    if (other.tag == "dreamwolf")
    {

        purpletrigger = false;

    }

}



private void Update()
{
    if (purpletrigger == true && Input.GetKeyDown(KeyCode.Q))
    {
        correctstuffyinTrigger.Play();

            dreampoints++;
            DreamPointsText.text = ("dream stuffies: " + dreampoints.ToString());
        }
}
}