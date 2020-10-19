using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBehaviour : MonoBehaviour
{
    public float moveSpeed = 10, turnSpeed = 30, jumpHeight;
    private float verticalInput, horizontalInput;

    public bool isGrounded;
    private Rigidbody rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * verticalInput);
        //transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        if(Input.GetKey(KeyCode.F))
        {
            moveSpeed = 30;
            
        }
        else
        {
            moveSpeed = 10;
            
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rBody.AddForce(new Vector3(0,20,0), ForceMode.Impulse);
            isGrounded = false;
        }
        
    }
}
