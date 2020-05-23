using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //Move Plyer Forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move Player
            //transform.position += Vector3.forward * Time.deltaTime * speed;
            playerRB.AddForce(new Vector3(0, 0, 0.5f), ForceMode.VelocityChange);

            //playerRB.rotation = Quaternion.LookRotation(Vector3.forward);

        }

        //Move Player Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Move Player
            //transform.position += Vector3.left * Time.deltaTime * speed;
            playerRB.AddForce(new Vector3(-0.5f, 0, 0), ForceMode.VelocityChange);

            //playerRB.rotation = Quaternion.LookRotation(Vector3.left);


        }

        //Move Player Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Move Player
            //transform.position -= Vector3.left * Time.deltaTime * speed;
            playerRB.AddForce(new Vector3(0.5f, 0, 0), ForceMode.VelocityChange);

            //playerRB.rotation = Quaternion.LookRotation(Vector3.right);

        }

        //Move Player Back
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move Player
            //transform.position -= Vector3.forward * Time.deltaTime * speed;
            playerRB.AddForce(new Vector3(0, 0, -0.5f), ForceMode.VelocityChange);

            //playerRB.rotation = Quaternion.LookRotation(Vector3.back);
        }
    }
}
