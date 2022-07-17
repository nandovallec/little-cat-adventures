using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour{


    public float translateX = 0;
    public float translateY = 0;
    public float rotateX = 0;
    public float rotateY = 0;
    public float rotateZ = 0;
    public float longZ = 40;
    public int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
     translateX = Random.Range(-4, 4);
     translateY = Random.Range(-4, 4);
     rotateX = Random.Range(-4, 4);
     rotateY = Random.Range(-4, 4);
     rotateZ = Random.Range(-4, 4);

}
    
    

    // Update is called once per frame
    void Update()
    {
        
        /*if(transform.position.y < 9) { 
        transform.position += Vector3.up * 0.1f;
        }
        else
        {
            transform.position += Vector3.down * 0.1f;
        }*/
        if (Input.GetKeyDown("a")) {
        transform.position = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));

        transform.Rotate(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360));
            transform.localScale = new Vector3(10, 10, Random.Range(0, 40));
        }

        timer += 1;

        if (timer == 60)
        {
            translateX = Random.Range(-4, 4);
            translateY = Random.Range(-4, 4);
            rotateX = Random.Range(-50, 50);
            rotateY = Random.Range(-50, 50);
            rotateZ = Random.Range(-50, 50); 
            longZ = Random.Range(-2, 2);
            timer = 0;
        }

        
        transform.position += Vector3.right * translateX * Time.deltaTime;
        transform.position += Vector3.up * translateY * Time.deltaTime;
        transform.localScale += Vector3.forward * longZ * Time.deltaTime;
        transform.Rotate(Vector3.right * rotateX * Time.deltaTime);
        transform.Rotate(Vector3.up * rotateY * Time.deltaTime);
        transform.Rotate(Vector3.forward * rotateZ * Time.deltaTime);



    }
}
