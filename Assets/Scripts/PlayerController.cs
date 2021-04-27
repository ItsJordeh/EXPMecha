using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 20f;
    public float inputHMove, inputVMove ;

    public bool isJumping, isRunning;
    
    public Vector3 movement;

    Vector3 x, z;






    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessInput();
        
    }
    void FixedUpdate()
    {
        ProcessMovement();
    }


    //Process users inputs for translation to movement
    void ProcessInput()
    {
        inputHMove = Input.GetAxis("Horizontal");
        inputVMove = Input.GetAxis("Vertical");

        x = transform.right * inputHMove;
        z = transform.forward * inputVMove;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }
        else isJumping = false;



        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = true;
        }
        else isRunning = false;


    }
    
    void ProcessMovement()
    {
        // movementX = inputHMove * 20f * Time.deltaTime;
        // movementY = inputVMove * 20f * Time.deltaTime;

        // if(movementX <= 0f)
        // {
        //     movementX = 0;
        // }

        movement = (x + z).normalized * speed;

        rb.AddForce(movement);


    }




}
    
  
