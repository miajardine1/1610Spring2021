using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theSecondConditions : MonoBehaviour
{
    int time = 20;

    void start()
    {

        if (time < 18)
        {
            Console.WriteLine("Good evening.");

        }
        else
        {
            Console.WriteLine("Good day.");
        }
    }
}
