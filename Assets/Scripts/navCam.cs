using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navCam : MonoBehaviour
{
    public float speed = 18.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float hAxis = Input.GetAxis("horizontal");
        float vAxis = Input.GetAxis("vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }
}
