using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;

    Vector3 movement;

    Rigidbody playerRB;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //movement
        movement.z = Input.GetAxis("Vertical");
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 moveVector = transform.TransformDirection(movement) * speed * Time.deltaTime;
        playerRB.velocity = new Vector3(moveVector.x, playerRB.velocity.y, moveVector.z);
        Debug.Log(playerRB.velocity);
    }
}
