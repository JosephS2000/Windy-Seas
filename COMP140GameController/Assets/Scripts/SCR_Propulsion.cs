using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Propulsion : MonoBehaviour
{
    public float wind = 0.5f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddRelativeForce(Vector3.forward * wind);
        }
    }
}
