using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    bool isFiring;
    bool stopFiring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void pointerDown()
    {
        stopFiring = false;
        makeFireVariableTrue();
    }

    public void pointerUp()
    {
        isFiring = false;
        stopFiring = true;
    }

    void makeFireVariableTrue()
    {
        isFiring = true;
    }

    void makeFireVariableFalse()
    {
        isFiring = false;
        if (!stopFiring)
        {
            Invoke("makeFireVariableTrue", 0.5f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            makeFireVariableFalse();
            Debug.Log("Fire in hole!!");
        }
    }
}
