using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNetwork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Application.internetReachability != NetworkReachability.NotReachable)
        {
            Debug.Log("Network Available");
        }
        else
        {
            Debug.Log("Network Not Available");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
