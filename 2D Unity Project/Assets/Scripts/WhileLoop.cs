using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
   
    void Start()
    {
        int i = 0;
        while(i<5)
        {
            Console.WriteLine(i);
            i++;
        }
    }

}
