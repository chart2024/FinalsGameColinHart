using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ball : MonoBehaviour
{
    public float forceAmt;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        Move();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Move();
    }
    private void Move()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(forceAmt * x, forceAmt * y);
    }
    
    

}
