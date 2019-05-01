using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{

    Scene currentScene = SceneManager.GetActiveScene();
    //public AudioClip StartScreen, Level1, EndScreen, GameOver;
    public AudioSource StartScreen, Level1, EndScreen, GameOver;
    
    void Start()
    {
        if (currentScene = Level1)
        {

        }

    }

    
    void Update()
    {
        
    }
}
