using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBehaviour : MonoBehaviour
{
    public int number, total;
    public string[] cars;

    void Start()
    {
        for (int i =0; i < number; i++)
        {
            total = i;
            print(total);
        }
    }
}
