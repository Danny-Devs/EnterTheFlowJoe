using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionZone : MonoBehaviour

{
    public AudioClip mySound;
    public AudioSource myAudio;

    void OnTriggerEnter(Collider collision)
    { 
       if (collision.gameObject.tag == "Sphere")
        {
            myAudio.PlayOneShot(mySound, 1.0f);
            Destroy(collision.gameObject);
            Debug.Log("Collided");
        }
    }
}

