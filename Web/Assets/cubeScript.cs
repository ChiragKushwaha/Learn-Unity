using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Invoke("cubeAnimation", 3.0f); 
    }
    void cubeAnimation()
    {
        GameObject.Find("Cube").GetComponent<Animator>().SetBool("isMove", true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
