using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraV2 : MonoBehaviour
{
    public GameObject target;
    public float rotateX = 50;
    public float rotateY = 5;
    public float rotateZ = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right * rotateX * Time.deltaTime);
            /*transform.Rotate(Vector3.up * rotateY * Time.deltaTime);
            transform.Rotate(Vector3.forward * rotateZ * Time.deltaTime);*/
        }
        if (Input.GetKey("z"))
        {
            transform.position += Vector3.forward * 0.5f;
        }
        if (Input.GetKey("q"))
        {
            transform.position += Vector3.right * -0.5f;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.forward * -0.5f;
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * 0.5f;
        }

        /* if (Input.GetKey(KeyCode.LeftShift))
         {
             transform.position += Vector3.up * -0.5f;
         }*/
    }
}
