using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("z"))
        {
            transform.Rotate(Vector3.right * -15f);
        }
        if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.up * -25f );
        }
        if (Input.GetKey("s"))
        {
            transform.Rotate(Vector3.right * 15f);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * 25f);
        }
       /* if (Input.GetKey("space"))
        {
            transform.Rotate += Vector3.up * 0.5f;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += new Vector3(0f,0f,0f);
        }*/
    }
}
