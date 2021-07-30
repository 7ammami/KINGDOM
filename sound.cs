using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    private AudioSource finishsound;
    // Start is called before the first frame update
    void Start()
    {
        finishsound = GetComponent<AudioSource>();
        finishsound.Play();
    }

}
