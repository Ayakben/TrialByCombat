using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;
    void Update()
    {
        //Temp use just to set the speed for now
        speed = 3;
        //Checks for player input
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        //Moves the player
        transform.position = transform.position + moveInput * speed * Time.deltaTime;
    }
}
