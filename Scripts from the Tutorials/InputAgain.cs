


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAgain : MonoBehaviour
{
    public Rigidbody2D ballRigidbody2D;
    public Vector2 direction;
    public Vector2 ydirection;
    public float speed = 3f;

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * speed;
        ballRigidbody2D.AddForce(direction, ForceMode2D.Force);

        if (Input.GetButtonDown("Jump"))
        {
            ballRigidbody2D.AddForce(ydirection, ForceMode2D.Force);
        }
    }
}
