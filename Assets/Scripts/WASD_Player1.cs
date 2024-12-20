using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WASD_Player1 : MonoBehaviour
{

    public float forceAmt = 5f;
    private Rigidbody2D rb;
    public Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * forceAmt);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * forceAmt);
        }
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
