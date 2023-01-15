using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rgbd2d;
    public float speed;
    public float acceleration = 2.0f;
    public float maxspeed = 60f;
    private float currentspeed = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetAxis("Horizontal") > 0) //it is positive
        {
            rgbd2d.velocity = new Vector2(speed, 0f);
            transform.Translate(Vector3.forward * currentspeed * Time.deltaTime);
            currentspeed += acceleration * Time.deltaTime;
        }
        else if (Input.GetAxis("Horizontal") < 0) //it is negative
        {
            rgbd2d.velocity = new Vector2(-speed, 0f);
            transform.Translate(Vector3.forward * currentspeed * Time.deltaTime);
            currentspeed += acceleration * Time.deltaTime;
        }
        else if (Input.GetAxis("Vertical") > 0) //it is positive
        {
            rgbd2d.velocity = new Vector2(0f, speed);
            transform.Translate(Vector3.forward * currentspeed * Time.deltaTime);
            currentspeed += acceleration * Time.deltaTime;
        }
        else if (Input.GetAxis("Vertical") < 0) //it is negative
        {
            rgbd2d.velocity = new Vector2(0f, -speed);
            transform.Translate(Vector3.forward * currentspeed * Time.deltaTime);
            currentspeed += acceleration * Time.deltaTime;
        }
        else if(Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
        {
            //stop
            rgbd2d.velocity = new Vector2(0f, 0f); 
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Door")
            Debug.Log("Level Completed");
        
        

    }
}
