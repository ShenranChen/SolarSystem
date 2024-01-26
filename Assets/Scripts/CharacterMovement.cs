using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10;

    float jumpHeight = 500;
    bool onGround = false;
    bool canDash = true;

    float dashForce = 20;
    float dashDuration = 0.5f;
    float dashCooldown = 2;
    float dashTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        dashTimer += Time.deltaTime;

        if (dashTimer > dashCooldown)
        {
            canDash = true;
        }

    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        Debug.Log(input);
        rb.velocity = input.y * transform.forward + input.x * transform.right;
        rb.velocity *= speed;
    }

    void OnJump()
    {
        if(onGround)
        {
            Debug.Log("JUMPED");
            rb.AddForce(jumpHeight * transform.up);

        }
    }

    //prevent jumping if not on ground
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }
    }

    void OnDash()
    {
        if(canDash)
        {
            rb.velocity = transform.forward * dashForce;
            dashTimer = 0;
            canDash = false;
            Invoke("StopDash", dashDuration);
        }

    }
    void StopDash()
    {
        rb.velocity = Vector2.zero;
    }
}
