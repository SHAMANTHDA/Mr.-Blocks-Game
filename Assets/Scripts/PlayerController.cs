using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rgbd2d;

    public GameObject gamewonpanel;

    public GameObject door;

    private bool isgamewon = false;

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
        if(isgamewon == true)
        {
            return;
        }

        if (Input.GetAxis("Horizontal") > 0) //it is positive
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
        else if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
        {
            //stop
            rgbd2d.velocity = new Vector2(0f, 0f);
        }
    }


    //private void OnTriggerEnter2D(Collider2D other) [this function is to use for non collidable objects]
    //{
    //    if (other.tag == "Door")
    //    {
    //        Debug.Log("Level Completed");
    //        gamewonpanel.SetActive(true);
    //        isgamewon = true;
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision) // [this function is used for collision test]
    {
        if (collision.gameObject == door)
        {
            gamewonpanel.SetActive(true);
            isgamewon = true;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // (or method )SceneManager.LoadScene(0);
    }
}