using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
   
    public int points = 0;

    public Text pointsText;

    public AudioSource softLullaby;
    public AudioSource babyCoos;
    public AudioSource distortedLullaby;

    private void Start()
    {
        /*
        softLullaby = GetComponent<AudioSource>();
        babyCoos = GetComponent<AudioSource>();
        distortedLullaby = GetComponent<AudioSource>();
        */

        softLullaby.Play();
        babyCoos.Play();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {


        if(other.tag == "stuffed animal")
        {
            points++;
            pointsText.text = ("stuffies: " + points.ToString());

            Debug.Log("in trigger");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "stuffed animal")
        {
            points--;
            pointsText.text = ("stuffies: " + points.ToString());

            Debug.Log("in trigger");
        }
    }

    private void Update()
    {
        if(points == 1)
            {
                softLullaby.Stop();
                babyCoos.Stop();

            if(distortedLullaby.isPlaying == false)
            {

                distortedLullaby.Play();
            }

            }
        
        
    }
}
