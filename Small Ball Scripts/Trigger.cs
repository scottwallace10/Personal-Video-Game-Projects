﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Trigger : MonoBehaviour
{
    public static int counter;

    public void OnTriggerEnter()
    {
        counter++;
    }
}
