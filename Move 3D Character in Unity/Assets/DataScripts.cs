using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Name", "MoJOJOJOJO");
        Debug.Log("Data Saved");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
