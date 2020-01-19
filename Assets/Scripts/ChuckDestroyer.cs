using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuckDestroyer : MonoBehaviour
{
    public AudioClip mySound;
    public AudioSource myAudio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {         
            Debug.Log("in here");
            //myAudio.Play();
            myAudio.PlayOneShot(mySound, 1.0f);
            Destroy(collision.gameObject);
        }
    }


}
