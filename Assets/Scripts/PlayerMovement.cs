using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    public float speed = 5f;
    public float jumpPower = 7f;
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

        if (Input.GetKeyDown(KeyCode.Space) && IsGounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            Debug.Log("jump work");
        }
            
        
        
        

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed,rb.velocity.y); 
    }
    private bool IsGounded()
    {
        Debug.Log("grounded =" + Physics2D.OverlapCircle(groundChecker.position, 0.2f, Ground));
        return Physics2D.OverlapCircle(groundChecker.position, 0.2f, Ground);
        
    }
   

}
