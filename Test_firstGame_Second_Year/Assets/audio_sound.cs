using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_sound : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Fire");
    }
}
