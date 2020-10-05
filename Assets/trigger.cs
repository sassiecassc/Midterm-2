using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<GameMaster>();


    }

  
}
