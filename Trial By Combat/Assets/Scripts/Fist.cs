using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist : MonoBehaviour
{
    public GameObject player;
    public GameObject fist;
    public float moveSpeed = 0.008f;
    public float distance;
    public float maxDistance = 2;
    void Update()
    {
        distance = Vector2.Distance(fist.transform.position, player.transform.position);
        if (Input.GetMouseButton(0) && (distance <= maxDistance))
        {
            transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), moveSpeed);
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            difference.Normalize();
            float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotation_z);
        }
        if (distance > maxDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
        }
    }   
}
