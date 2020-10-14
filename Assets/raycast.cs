using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{

    public float enemyDetectDist = 0.5f;
    public float enemySpeed = 7f;




    // Update is called once per frame
    void Update()
    {
        //raycast moving up and down

        if (gameObject.CompareTag("enemyUp"))
        {
            Ray2D enemyRayup = new Ray2D(transform.position, transform.up);
            Debug.DrawRay(enemyRayup.origin, enemyRayup.direction * enemyDetectDist, Color.white);

            if (Physics2D.Raycast(enemyRayup.origin, enemyRayup.direction, enemyDetectDist) && gameObject.CompareTag("enemyUp"))
            {
                transform.Rotate(new Vector3(0, 0, 180));

            }
            else
            {

                transform.Translate(0, Time.deltaTime * enemySpeed, 0);
            }
        }

        //raycast moving left and right

        if (gameObject.CompareTag("enemySide"))
        {
            Ray2D enemyRayside = new Ray2D(transform.position, transform.up);
            Debug.DrawRay(enemyRayside.origin, enemyRayside.direction * enemyDetectDist, Color.red);

            if (Physics2D.Raycast(enemyRayside.origin, enemyRayside.direction, enemyDetectDist) && gameObject.CompareTag("enemySide"))
            {
                transform.Rotate(new Vector3(0, 0, 180));

            }
            else
            {

                transform.Translate(0, Time.deltaTime * enemySpeed, 0);
            }
        }
  
    }
}
