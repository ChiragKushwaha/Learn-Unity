using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioScript : MonoBehaviour
{
    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.clip = Resources.Load<AudioClip>("shotAudio");
        myAudio.Play();
        //Delay in Audio Play
        //myAudio.PlayDelayed(2.0f);
        Invoke("audioFinished", myAudio.clip.length);
        //Gives the name of the current Scene
        //Debug.Log(SceneManager.GetActiveScene().name);
    }

    void audioFinished()
    {
        Debug.Log("Audio Finished");
    }
    // Update is called once per frame
    void Update()
    {
        //if (!myAudio.isPlaying)
        //{
        //    Debug.Log("Audio Stopped Playing");
        //}
    }
}
