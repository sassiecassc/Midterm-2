﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteChange : MonoBehaviour
{
    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
    }

    void Update()
    {
        if (GameObject.Find("crib").GetComponent<GameMaster>().points == 8) // If the space bar is pushed down
        {
            ChangeSprite(); // call method to change sprite
        }
    }

    void ChangeSprite()
    {
        if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = sprite2;
        }
        //else
       // {
        //    spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
        //}
    }
}
