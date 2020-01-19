using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuckDestroyerNEW : MonoBehaviour
{
    public AudioClip mySound;
    public AudioSource myAudio;

    private void OnTriggerEnter(Collider collision)
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
