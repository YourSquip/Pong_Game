using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxis("Vertical");
            rb.velocity = new Vector2(0, movement * speed);
        }
        else
        {
            movement = Input.GetAxis("Vertical2");
            rb.velocity = new Vector2(0, movement * speed);
        }
        rb.rotation = 0;
        
    }
}
