using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inBlueTrigger : MonoBehaviour
{

    public int dreampoints = 0;

    public Text pointsDreamText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D pig)
    {
        if(pig.tag == "dreampig")
        {

            dreampoints++;
            pointsDreamText.text = ("dream stuffies: " + dreampoints.ToString());
        }
    }

    private void OnTriggerExit2D(Collider2D pig)
    {
        if (pig.tag == "dreampig")
        {

            dreampoints--;
            pointsDreamText.text = ("dream stuffies: " + dreampoints.ToString());
        }
    }
}
