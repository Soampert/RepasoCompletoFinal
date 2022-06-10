using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource AS;

    public AudioClip[] Sound;



    // Start is called before the first frame update
    void Start()
    {
        AS = FindObjectOfType<AudioSource>();
    }

    public void PlaySound(int SoundNum)
    {
        AS.PlayOneShot(Sound[SoundNum], 1);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
