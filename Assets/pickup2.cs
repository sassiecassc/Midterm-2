using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup2 : MonoBehaviour
{

    public GameObject player;

    public bool inTrigger;

    AudioSource pickUpStuffy;

    private void Start()
    {
        pickUpStuffy = GetComponent<AudioSource>();
    }

    private void OnTriggerStay2D(Collider2D ghost)
    {

        if (ghost.CompareTag("Player"))
        {

            inTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D ghost)
    {
        if (ghost.CompareTag("Player"))
        {

            inTrigger = false;
        }
    }


    private void Update()
    {
        if (inTrigger == true && Input.GetKeyDown(KeyCode.E))
        {
            this.transform.parent = player.transform;
            
            transform.localPosition = new Vector3(2, 0.8f, 1.5f);
            print(transform.localPosition.y);


            SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>();
            mySpriteRenderer.sortingLayerName = "picked up items";
            mySpriteRenderer.sortingOrder = 4;

            pickUpStuffy.Play();
        }

        if (inTrigger == true && Input.GetKeyDown(KeyCode.Q))
        {
           this.transform.parent = null;
        }
    }

    
}
