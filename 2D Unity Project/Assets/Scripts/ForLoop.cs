using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    private void Start()
    {
        int[] myNum = { 10, 20, 30, 40 };
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        for(int i = 0; i<=10; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
    
}
