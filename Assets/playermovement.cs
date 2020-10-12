using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D thisRigidbody2D;
    public float speed = 7f;

    

    Vector2 moveDirection;


    public GameObject mazeEntrance;
    public float teleportimer = 5;
    public bool timeIsRunning = false;
    public bool teleported = false;

    

    private void Start()
    {
        //timer is not counting down
        timeIsRunning = true;

        //a change in code

    }

    void Update()
    {
       

        
        //if player finished first level 
        if ((GameObject.Find("crib").GetComponent<GameMaster>().points) == 1)
        {
            //timer goes off
            //new music maybe?
           

            if (teleportimer > 0)
            {

                teleportimer -= Time.deltaTime;
            }
            else
            {

                teleportimer = 0;
                timeIsRunning = false;
            }

            //transport player to second level
            if (teleportimer == 0 && teleported == false)
            {

                thisRigidbody2D.position = new Vector3(-111.8f, -50.1f, 0f);

                thisRigidbody2D.position = mazeEntrance.transform.position;
                teleported = true;

                
              

            }

        }
     
            
    }

    //move code
    private void FixedUpdate()
    {
        //move code
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");

        thisRigidbody2D.MovePosition(thisRigidbody2D.position + moveDirection * speed * Time.deltaTime);
    }

}

