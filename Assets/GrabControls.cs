using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabControls : MonoBehaviour
{
    /*
    public Transform grabDetect;
    public Transform itemHolder;
    public float rayDist;

    bool holding;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

   
        RaycastHit2D grabcheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if(grabcheck.collider != null && grabcheck.collider.tag == "stuffed animal")
        {
           
            if(Input.GetKeyDown(KeyCode.E))
            {
                holding = !holding;
              

            }
            else
            {

              
            }
            if (holding)
            {


                grabcheck.collider.gameObject.transform.parent = itemHolder;
                grabcheck.collider.gameObject.transform.position = itemHolder.position;
                grabcheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
               


                //grabcheck.collider.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            }
            else
            {
                grabcheck.collider.gameObject.transform.parent = null;
                grabcheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;

                //grabcheck.collider.gameObject.GetComponent<PolygonCollider2D>().enabled = true;
            }
        }
        
    }
    */
}
