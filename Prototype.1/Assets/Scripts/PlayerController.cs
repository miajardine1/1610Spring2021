using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        //Move vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
