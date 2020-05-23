using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    GameObject playerObj;
    Vector3 cameraOffSet;
    // Start is called before the first frame update
    void Start()
    {
       playerObj = GameObject.Find("Player");
        cameraOffSet = new Vector3(0, 1, -3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObj.transform.position + cameraOffSet;
    }
}
