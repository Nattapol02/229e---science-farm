using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Vector2 move;
    float speed;
    //private Vector2 jump = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        speed = 700f;
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        //if (Input.GetButtonDown("Jump"))
        {
            //jump
        }
    }
    

    private void FixedUpdate()
    {
        //rb2D.AddForce(move * Time.fixedDeltaTime , jump);
        //jump = false;
        rb2D.AddForce(move * speed * Time.deltaTime);
    }
}

