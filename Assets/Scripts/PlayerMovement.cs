using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    public float speed = 5f;
    public float jumpPower = 7f;
    private bool canJump = false;
    private bool isGrounded = false;
    [SerializeField] private float coyoteTime = 0.5f;
    private float cTimer;
    private Rigidbody2D rb;


    [SerializeField] private LayerMask Ground;
    [SerializeField] private Transform groundChecker;
   





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded || canJump)
            {
                Jump();
            }

            
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0.5f)
        { 
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        
        
        
        

    }
    private void FixedUpdate()
    {
        IsGrounded();
        rb.velocity = new Vector2(horizontal * speed,rb.velocity.y); 
    }
    void IsGrounded()
    {
        
         isGrounded = Physics2D.OverlapCircle(groundChecker.position, 0.2f, Ground);
        if (isGrounded)
        {
            canJump = true;
            cTimer = coyoteTime;
        }
        else
        {
            cTimer -= Time.deltaTime;
        }

        if(cTimer <= 0f)
        {
            canJump = false;
        }
        
        
    }


    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        Debug.Log("jump work");
        canJump = false;
    }
   

}
