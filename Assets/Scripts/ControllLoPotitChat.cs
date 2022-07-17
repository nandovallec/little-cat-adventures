using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllLoPotitChat : MonoBehaviour
{

    public bool stop = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ///////MOVEMENT/////////////////////////////////////////
        if(!stop){
            if (Input.GetKey("w"))
            {
                GetComponent<Transform>().Translate(Vector3.forward * 0.25f, Space.Self);
            }
            if (Input.GetKey("a"))
            {
                transform.Rotate(Vector3.up * -5f);
            }
            if (Input.GetKey("s"))
            {
                GetComponent<Transform>().Translate(Vector3.forward * -0.1f, Space.Self);
            }
            if (Input.GetKey("d"))
            {
                transform.Rotate(Vector3.up * 5f);
            }
            if (Input.GetKeyDown("space"))
            {
                transform.position += Vector3.up * 2f;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += Vector3.up *0.5f;
                transform.rotation = Quaternion.Euler(0,180, 0);
            }

            if (Input.GetKeyDown("l"))
            {
                transform.position += new Vector3(0,0,0);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        /////////CHANGE SIZE//////////////////////////////////////////////////////



        /////////Z/////////
        if (Input.GetKey("t"))
        {
            if (transform.localScale[2] < 20) { 
           // float a = transform.localScale[2];
           //while (transform.localScale[2] < a + 5)
           //{
                transform.localScale += new Vector3(0, 0, 0.5f); 
                // }  
            }
        }

        if (Input.GetKey("r"))
        {
            if (transform.localScale[2] > 0.5)
            {
                // float a = transform.localScale[2];
                //while (transform.localScale[2] < a + 5)
                //{

                transform.localScale += new Vector3(0, 0, -0.5f);
                // }  
            }
        }

        ///////////X///////////
        if (Input.GetKey("g"))
        {
            if (transform.localScale[0] < 20)
            {
                // float a = transform.localScale[2];
                //while (transform.localScale[2] < a + 5)
                //{

                transform.localScale += new Vector3(0.5f, 0, 0);
                // }  
            }

            /*if (transform.localScale[0] == 5)
            {
                // float a = transform.localScale[2];
                //while (transform.localScale[2] < a + 5)
                //{

                transform.localScale += new Vector3(10f, 0, 0);
                new WaitForSeconds(1);
                // }  
            }*/
        }

        if (Input.GetKey("f"))
        {
           /* if (transform.localScale[0] == 5)
            {
                // float a = transform.localScale[2];
                //while (transform.localScale[2] < a + 5)
                //{

                transform.localScale += new Vector3(-3f, 0, 0 );
                new WaitForSeconds(1);
                // }  
            }
           */
            if (transform.localScale[0] > 0.5 )
            {

                    transform.localScale += new Vector3(-0.5f, 0, 0);
                // }  
            }
        }


        /////////Y/////////
        if (Input.GetKey("b"))
        {
            if (transform.localScale[1] < 20)
            {
                // float a = transform.localScale[2];
                //while (transform.localScale[2] < a + 5)
                //{

                transform.localScale += new Vector3(0, 0.5f, 0);
                // }  
            }
        }

        if (Input.GetKey("v"))
        {
            if (transform.localScale[1] > 0.5)
            {
                // float a = transform.localScale[2];
                //while (transform.localScale[2] < a + 5)
                //{

                transform.localScale += new Vector3(0, -0.5f, 0);
                // }  
            }
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "notpassable"){
            stop = true;
            GetComponent<Transform>().Translate(Vector3.forward * -0.5f, Space.Self);
            Invoke("setStop", 0.3f);
        }
    }

    private void setStop(){
        stop = false;
    }
}
