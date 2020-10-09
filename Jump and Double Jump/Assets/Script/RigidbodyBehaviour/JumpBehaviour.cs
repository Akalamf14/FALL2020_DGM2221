using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehaviour : MonoBehaviour
{
    public float jumpHeight;
    public bool isGrounded;
    private Rigidbody gameCharacter;
    

    void Start()
    {
       gameCharacter = GetComponent<Rigidbody>();
       
    }


    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            gameCharacter.AddForce(new Vector3(0,20,0), ForceMode.Impulse);
            isGrounded = false;
        }
    }


}
