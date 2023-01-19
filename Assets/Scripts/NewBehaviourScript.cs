using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private void OnDisable()
    {
        //This Function is called when the behaviour becomes disabled or inactive
    }

    private void OnEnable()
    {
        /// This function is called when the object becomes enabled and active
    }

    private void Awake()
    {
        //Awake is called when the script instance is being loaded
    }

    private void OnDestroy()
    {
        //This function is called when the monobehaviour is destroyes i.e it is used to destroy an object
    }

    private void OnMouseDown() // also called as onmouseclick
    {
        //OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or collider
    }

    private void FixedUpdate()
    {
        //This function is called every fixed framerate frame, if the monobehaviour is enabled
    }
    // Start is called before the first frame update
    void Start()
    {
        //Start is called just before any of the update methods is called the first time
    }

    // Update is called once per frame
    void Update()
    {
        //Update is called every frame if the monobehaviour is enabled
    }

    private void OnCollisionEnter(Collision collision)
    {
        // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
    }
    private void LateUpdate()
    {
        //LateUpdate is called every frame if the monobehaviour is enabled
    }
}

    //WaitForSeconds
    //Suspends the coroutine execution for the given amount of seconds using scaled time.





