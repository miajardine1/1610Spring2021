using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 3;
    private Vector3 direction = Vector3.zero;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        direction.Set(horizontalInput * speed, 0, 0);
        transform.Translate(direction * Time.deltaTime);
    }
}
