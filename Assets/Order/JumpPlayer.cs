using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    private Rigidbody2D rd2d;
    [SerializeField] private int jumpPower;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool isGrounded;
    
    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(1.8f, 0.3f), CapsuleDirection2D.Horizontal ,0 ,groundLayer);
        if (Input.GetButtonDown("Jump"))
        {
            rd2d.velocity = new Vector2(rd2d.velocity.x, jumpPower);
        }    
            
    }
}
