using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb; // Corrected the capitalization of Rigidbody
    public float moveSpeed = 2f; // Added a semicolon

    private float xInput;
    private float zInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>(); // Corrected the capitalization of Rigidbody
    }

    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate() // Corrected the capitalization of FixedUpdate
    {
        Move();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput));
    }
}
