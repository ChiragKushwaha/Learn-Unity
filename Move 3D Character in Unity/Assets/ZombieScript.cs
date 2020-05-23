using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    Animator animZombie;
    //float speed = 10.0f;
    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

        animZombie = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        //Walk Animation Zombie
        if (Input.GetKeyDown(KeyCode.UpArrow)
            || Input.GetKeyDown(KeyCode.DownArrow)
            || Input.GetKeyDown(KeyCode.LeftArrow)
            || Input.GetKeyDown(KeyCode.RightArrow))
        {   
            //Animate Walk
            animZombie.SetBool("Walk", true);
            animZombie.SetBool("Stop", false);
        }
 
        //Stop Animation Zombie
        if (Input.GetKeyUp(KeyCode.UpArrow) 
            || Input.GetKeyUp(KeyCode.DownArrow) 
            || Input.GetKeyUp(KeyCode.LeftArrow) 
            || Input.GetKeyUp(KeyCode.RightArrow))
        {
            //Anime Stop
            animZombie.SetBool("Walk", false);
            animZombie.SetBool("Stop", true);
        }
        
    }
    private void FixedUpdate()
    {
        //Move Plyer Forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move Player
            //transform.position += Vector3.forward * Time.deltaTime * speed;
            playerRB.AddForce(new Vector3(0, 0, 5), ForceMode.VelocityChange);

            playerRB.rotation = Quaternion.LookRotation(Vector3.forward);

        }

        //Move Player Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Move Player
            //transform.position += Vector3.left * Time.deltaTime * speed;
            playerRB.AddForce(new Vector3(-5, 0, 0), ForceMode.VelocityChange);

            playerRB.rotation = Quaternion.LookRotation(Vector3.left);


        }

        //Move Player Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Move Player
            //transform.position -= Vector3.left * Time.deltaTime * speed;
            playerRB.AddForce(new Vector3(5, 0, 0), ForceMode.VelocityChange);

            playerRB.rotation = Quaternion.LookRotation(Vector3.right);

        }

        //Move Player Back
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move Player
            //transform.position -= Vector3.forward * Time.deltaTime * speed;
            playerRB.AddForce(new Vector3(0, 0, -5), ForceMode.VelocityChange);

            playerRB.rotation = Quaternion.LookRotation(Vector3.back);
        } 
    }
}
