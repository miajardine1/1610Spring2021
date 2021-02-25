using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
   
    void Start()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] myNum = { 10, 20, 30, 40 };
        Console.WriteLine(cars[0]);
        cars[0] = "Opel";
        for(int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
        foreach(string i in cars)
        {
            Console.WriteLine(i);
        }
    }

}
