using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theThirdConditions : MonoBehaviour
{
    int time = 20;
    string result = (time < 18) ? "Good day." : "Good evening.";
    Console.WriteLine(result);
}
