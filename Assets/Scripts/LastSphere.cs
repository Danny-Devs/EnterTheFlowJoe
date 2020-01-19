using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastSphere : MonoBehaviour
{

    public AudioClip goodJob;
    public AudioClip bruceLee;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Nunchuck")
        {
            Invoke("PlayGoodJob", 3f);
            audioSource.PlayOneShot(bruceLee);
        }
    }

    void PlayGoodJob ()
    {
        audioSource.PlayOneShot(goodJob);
    }
}
