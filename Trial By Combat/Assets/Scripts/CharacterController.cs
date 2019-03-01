using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public bool isGrounded;
    public float speed;
    public float jumpHeight;

    void Start()
    {
        //Temp use just to set the speed and jump height for now
        isGrounded = false;
        speed = 3;
        jumpHeight = 7;
    }
    void Update()
    {
        //Checks horizontal input
        Vector3 horInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        //Moves the player
        transform.position = transform.position + horInput * speed * Time.deltaTime;
        //Makes the player jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
    //Checks if the player is on the ground
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
