﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempertureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TempertureTest()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature, then...
        if (coffeeTemperature > hotLimitTemperature)
        {
            //... do this.
            print("Coffee is too hot.");

        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature, then...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those, then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}
