using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Canvas/Text").GetComponent < Text >().text = "Testing Text";
    }

    //public void buttonTestMethod()
    //{
    //    Debug.Log("Button name is : "+ EventSystem.current.currentSelectedGameObject.name);
    //}

    public void buttonTestMethod(Button btn)
    {
        Debug.Log("Button name is : " + btn.name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
