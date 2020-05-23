using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Play Global
    private static SoundScript instance = null;
    public static SoundScript Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    //Play Global End

    // Update is called once per frame
    void Update()
    {
        
    }
}
