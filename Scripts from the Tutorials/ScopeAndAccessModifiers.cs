﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifers : MonoBehaviour
{
    public int alpha = 5;


    private int beta = 0;
    private int gamma = 5;
    private int pens = 0;
    private int crayons = 5;

    private AnotherClass myOtherClass;


    void Start()
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }


    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
