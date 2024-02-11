using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rbMovement;
    



    // Start is called before the first frame update
    void Start()
    {
        rbMovement = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if i want movement to stop immediately change "GetAxis" to "GetAxisRaw"
        float dirX = Input.GetAxis("Horizontal");
        rbMovement.velocity = new Vector2(dirX * 5f, rbMovement.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rbMovement.velocity = new Vector2(rbMovement.velocity.x, 7f);
        }
        
        
    }
}
