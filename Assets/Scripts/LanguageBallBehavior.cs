using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class LanguageBallBehavior : MonoBehaviour
{
    public AudioClip[] kungFuSoundArray;
    public AudioSource audioSource;
    public float speed = 2f;
    Renderer rend;
    Rigidbody rb;
    bool isMoving = true;
    public GameObject inkBlotchPrefab;
    // public GameObject itsuPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Language Trigger Box")
        {
            rend.enabled = true;
            Debug.Log("Sphere entered collider.");
        }

        if (other.gameObject.tag == "Nunchuck")
        {
            // freeze the Language Ball position
            // this isn't working: rb.constraints = RigidbodyConstraints.FreezePosition;
            Instantiate(inkBlotchPrefab, this.transform.position, Quaternion.identity);
            //isMoving = false;
            audioSource.PlayOneShot(kungFuSoundArray[Random.Range(0, kungFuSoundArray.Length)], 1f);
            Destroy(this.gameObject);
        }


    }

}
