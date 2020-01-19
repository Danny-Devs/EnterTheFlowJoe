using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] spheres;
    public Transform[] points;
    public float beat = 60 / 105 * 2;
    private float timer;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>beat)
        {
            GameObject sphere = Instantiate(spheres[Random.Range(0,2)], points[Random.Range(0,4)]);
            sphere.transform.localPosition = Vector3.zero;
            sphere.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
  
        }
        timer += Time.deltaTime;
    }
}
