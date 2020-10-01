using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 10;
    private float verticalInput, horizontalInput;

    private Rigidbody rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * horizontalInput);

        if(Input.GetKey(KeyCode.F))
        {
            moveSpeed = 30;
            
        }
        else
        {
            moveSpeed = 10;
            
        }
        
    }
}
