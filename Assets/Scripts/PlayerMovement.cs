using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;

    // FixedUpdate is called once per frame when physics is involved - it is recommended
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}
