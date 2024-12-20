using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OL_Player2 : MonoBehaviour
{

    public float forceAmt = 5f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            rb.AddForce(Vector2.up * forceAmt);
        }
        if (Input.GetKey(KeyCode.L))
        {
            rb.AddForce(Vector2.down * forceAmt);
        }
    }
}