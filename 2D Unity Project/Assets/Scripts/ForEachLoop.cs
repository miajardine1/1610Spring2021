using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour
{
  
   void Start()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach(string i in cars)
        {
            Console.WriteLine(i);
        }
    }


}
