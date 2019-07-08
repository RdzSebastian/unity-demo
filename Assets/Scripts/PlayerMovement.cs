using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 5000f;
    public float sidewaysFoce = 350f;
    public float horizontalMove = 0f;
    public float jumpForce = 20f;
    public bool onGround = false;
    public bool jump = false;

    private void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * sidewaysFoce;
        if (Input.GetButtonDown("Jump") && Int32.Parse(SceneManager.GetActiveScene().name) >= 4 )
        {
            jump = true;
        }
    }


    void FixedUpdate()
    {
        
        //Add a foward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        Move(horizontalMove * Time.fixedDeltaTime);

        rb.AddForce(-Vector3.up, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }

    public void Move(float move)
    {
        if (onGround) { 
            rb.AddForce(horizontalMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (onGround && jump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
            jump = false;

        }
    }
}
