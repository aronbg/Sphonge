﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killfirewithout : MonoBehaviour
{

    public SpriteRenderer lastlake;
    public GameObject fire;


    public void Update()
    {

        if (lastlake.color.a >=0.9f)
        {
            fire.SetActive(false);
            Invoke("Destroywater", 0.33f);
            
        }


    }
    public void Destroywater()
    {
        lastlake.color = new Color(1, 1, 1, 0);
        gameObject.SetActive(false);
    }
   
}