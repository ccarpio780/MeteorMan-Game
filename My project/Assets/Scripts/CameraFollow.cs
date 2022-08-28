using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    


    AudioSource bgMusic;
    // Start is called before the first frame update
    void Start()
    {
        
        bgMusic = GetComponent<AudioSource>();
    }

    
    void LateUpdate()
    {
        

        if (Input.GetKeyDown("m"))
        {
            if (bgMusic.isPlaying)
            {
                bgMusic.Stop();
            }
            else if (!bgMusic.isPlaying)
            {
                bgMusic.Play();
            }
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(1);
        }
    }



}//class
