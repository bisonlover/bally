using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_player : MonoBehaviour {
    public float speed;
    public float speedH = 2.0f;

    public GameObject bally;

    private Rigidbody rb;
    public float yaw = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        


        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement = Quaternion.Euler(0, yaw, 0) * movement;

        rb.AddForce(movement * speed);

        rb.AddTorque(transform.up * moveHorizontal *100);
        rb.AddTorque(transform.right * moveVertical);
    }
}
