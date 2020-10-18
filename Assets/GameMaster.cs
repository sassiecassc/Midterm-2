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
    public AudioSource stateSwitchSound;

    private void Start()
    {
     

        softLullaby.Play();
        babyCoos.Play();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {


        if(other.tag == "stuffed animal")
        {
            points++;
            pointsText.text = ("stuffies: " + points.ToString());

           
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "stuffed animal")
        {
            points--;
            pointsText.text = ("stuffies: " + points.ToString());

           
        }
    }

    private void Update()
    {
        if (stateSwitchSound.isPlaying == false)
        {
            if (points == 1)
            {

                stateSwitchSound.Play();
            }
        }
         

        if((GameObject.Find("-player").GetComponent<playermovement>().teleportimer) == 0)
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
