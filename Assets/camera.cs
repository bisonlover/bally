using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    public GameObject sphere;
    public float speedH = 2.0f;
    private float yaw = 0.0f;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
        offset = transform.position - sphere.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        yaw += speedH * Input.GetAxis("Mouse x");
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        sphere.GetComponent<script_player>().yaw = yaw;
        transform.position = sphere.transform.position + offset;
    }
}
