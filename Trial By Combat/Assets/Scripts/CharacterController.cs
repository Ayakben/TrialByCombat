using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public bool isJumping;
    public float speed;
    public Vector2 jump;
    public float jumpHeight;

    void Start()
    {
        //Temp use just to set the speed and height for now
        speed = 3;
        jumpHeight = 7;
        jump = new Vector2(0.0f, jumpHeight);
    }
    void Update()
    {
        //Checks for player input
        Vector3 horInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        float vertCheck = Input.GetAxis("Vertical");
        Vector3 vertInput = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
        //Moves the player
        transform.position = transform.position + horInput * speed * Time.deltaTime;
        //Makes the player jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(jump, ForceMode2D.Impulse);
        }
    }
}
