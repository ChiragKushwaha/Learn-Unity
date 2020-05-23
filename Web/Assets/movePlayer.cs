using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    Rigidbody playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
         playerRigidBody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   //Move Player Forward   
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidBody.AddForce(new Vector3(0, 0, 0.1f), ForceMode.VelocityChange);
            //Vector3 playerPosition = transform.position;
            //playerPosition.z += 0.1f;
            //transform.position = playerPosition;
        }
        //Move Player Backward 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidBody.AddForce(new Vector3(0, 0, -0.1f), ForceMode.VelocityChange);
            //Vector3 playerPosition = transform.position;
            //playerPosition.z -= 0.1f;
            //transform.position = playerPosition;
        }
        //Move Player Left 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidBody.AddForce(new Vector3(-0.1f, 0, 0), ForceMode.VelocityChange);
            //Vector3 playerPosition = transform.position;
            //playerPosition.x -= 0.1f;
            //transform.position = playerPosition;
        }
        //Move Player Right 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidBody.AddForce(new Vector3(0.1f , 0, 0), ForceMode.VelocityChange);
            //Vector3 playerPosition = transform.position;
            //playerPosition.x += 0.1f;
            //transform.position = playerPosition;
        }
        //Player Jump 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidBody.AddForce(new Vector3(0, 5, 0), ForceMode.VelocityChange);
            //Vector3 playerPosition = transform.position;
            //playerPosition.x += 0.1f;
            //transform.position = playerPosition;
        }
    }
}
