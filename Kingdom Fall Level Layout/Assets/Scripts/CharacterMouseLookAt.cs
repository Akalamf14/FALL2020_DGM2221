using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouseLookAt : MonoBehaviour
{
   public Vector3Data mouseLocation;
   private CharacterController controller;
   private Vector3 movement;

   public float rotateSpeed = 30f, gravity = -9.81f;
   public FloatData jumpForce;
   private float yVar;

   public FloatData normalSpeed, fastSpeed;
   private FloatData moveSpeed;
   private bool canMove = true;

   private int jumpCount;
   private int maxJumpCount = 1;


   private void Start()
   {
       moveSpeed = normalSpeed;
       controller = GetComponent<CharacterController>();
       jumpForce.value = 3.5f;
       
   }

   void Update()
   {
       Transform transform1;
       (transform1 = transform).LookAt(mouseLocation.value);
       var transformRotation = transform1.eulerAngles;
       transformRotation.x = 0;
       transformRotation.z = 0;
       transformRotation.y -= 90;
       transform.rotation = Quaternion.Euler(transformRotation);

       if(Input.GetKeyDown(KeyCode.LeftShift))
       {
           moveSpeed = fastSpeed;
       }

       if(Input.GetKeyUp(KeyCode.LeftShift))
       {
           moveSpeed = normalSpeed;
       }

       var vInput = Input.GetAxis("Vertical") * moveSpeed.value;

       movement.Set(vInput, yVar, 0);

       yVar += gravity * Time.deltaTime;

       if(controller.isGrounded && movement.y < 0)
       {
           yVar = -1f;
           jumpCount = 0;
       }

       if(Input.GetButtonDown("Jump") && jumpCount < maxJumpCount)
       {
            yVar = jumpForce.value;
            jumpCount++;
        
        }
       
        movement = transform.TransformDirection(movement);
        controller.Move((movement) * Time.deltaTime);
   }

    /*
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
        {
            return;
        }
    
        if (hit.moveDirection.y < -0.3)
        {
            return;
        }
        StartCoroutine(KnockBack(hit, body));
    }

    
    public float pushPower = 10.0f;
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();

    private IEnumerator KnockBack (ControllerColliderHit hit, Rigidbody body)
    {
        canMove = false;
        var i = 2f;
       
        movement = -hit.moveDirection;
        movement.y = -1;
        while (i > 0)
        {
            yield return wffu;
            i -= 0.1f;
            controller.Move((movement) * Time.deltaTime);
            
            var pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
            var forces = pushDir * pushPower;
            body.AddForce(forces);
        }

    }
    */


}
