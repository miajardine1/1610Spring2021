﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    public Vector2 direction;
    public Vector 2 yDirection;


    void Update()
    {
        if (UserInput.GetKey(KeyCode.RightArrow))
        {
            ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
        }

        if (UserInput.GetKey(KeyCode.LeftArrow))
        {
            ballRigidbody2D.AddForce(-direction, ForceMode2D.Force);
        }

        if (UserInput.GetKey(KeyCode.UpArrow))
        {
            ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
        }
}
