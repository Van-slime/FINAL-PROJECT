using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundmusic : MonoBehaviour
{
    private static backgroundmusic backgroundMusic;
    void awake()
    {
        if(backgroundMusic == null)
        {
           backgroundMusic = this;
           DontDestroyOnLoad(backgroundMusic);
        }
    else
    {
        Destroy(gameObject);
    }
  }
}