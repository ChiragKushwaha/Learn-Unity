using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("MoveToSceneTwo", 3.90f);
    }
    void MoveToSceneTwo()
    {
        SceneManager.LoadScene("Scene2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
