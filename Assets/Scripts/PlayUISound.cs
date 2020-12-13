using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayUISound : MonoBehaviour
{
    public string eventName = null;
    public GameObject mainCamera;


    public void Play()
    {
        
        if(!string.IsNullOrEmpty(eventName))
        {
            AkSoundEngine.PostEvent(eventName, mainCamera);
        }
    }

    
}
