using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cube")
                {
                    SceneManager.LoadScene("SceneTwo");
                }
                else if (hit.transform.name == "Sphere")
                {
                    SceneManager.LoadScene("SceneThree");
                }
                else if (hit.transform.name == "Capsule")
                {
                    SceneManager.LoadScene("SceneOne");
                }
            }
        }
    }
}
