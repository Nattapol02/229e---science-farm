using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer2 : MonoBehaviour
{
    public float speed;
    public float jump;
    private float Move;
    public Rigidbody2D rd2d;
    public bool isJumping;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rd2d.velocity = new Vector2(speed * Move, rd2d.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rd2d.AddForce(new Vector2(rd2d.velocity.x , jump));
        }
    }

    //private void OnCollisionEnter2D(Collision2D other)
    //{
        //if (other.gameObject.CompareTag("Floor"))
        //{
            //isJumping = false;
        //}
    //}

    //private void OnCollisionExit2D(Collision2D other)
    //{
        //if (other.gameObject.CompareTag("Floor"))
        //{
            //isJumping = true;
        //}
    //}
}
