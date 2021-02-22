using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theFirstConditions : MonoBehaviour
{
    int x = 20;
    int y = 18;

    void start()
    {

        if (x > y)
        {
            Console.WriteLine("x is greater than y");
        }
    }
}
