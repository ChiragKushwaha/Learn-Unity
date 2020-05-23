using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isOnTouchDevice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(SystemInfo.deviceType == DeviceType.Handheld)
        {
            //This is a touch device
        }
        else
        {
            //This is a non touch device
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
