using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoLoop : MonoBehaviour
{ 
    void Start()
    {
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i < 5);
    }

}
