using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    public float acceler = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Time.timeScale == 0f)
            return;

        Vector3 acc = Input.acceleration;
        if (acc.sqrMagnitude > 0.01f)
        {
            movement.x = acc.x;
            movement.y = acc.y;
        }
        else
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }


    }

    void FixedUpdate()
    {
        rb.velocity = movement * speed;
    }

}

