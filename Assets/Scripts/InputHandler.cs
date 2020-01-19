using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputHandler : MonoBehaviour
{
    public TrailRenderer leftHandTrail;
    public TrailRenderer rightHandTrail;
    public GameObject leftHandTrailGO;
    public GameObject rightHandTrailGO;
    public float fadeTime = 8f;

    void Start()
    {
        leftHandTrailGO.SetActive(false);
        rightHandTrailGO.SetActive(false);
    }

    void Update()
    {
        // left hand
        // OVRInput.RawButton.LIndexTrigger
        // returns true if the left index finger trigger has been pressed more than halfway.
        // (Interpret the trigger as a button).

        if (OVRInput.GetDown(OVRInput.Button.One)) 
        {
            SceneManager.LoadScene("mainScaled TimelineTest");
        }

        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            SceneManager.LoadScene("MenuScene");
        }

        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger) && leftHandTrailGO.activeInHierarchy == false)
        {
                leftHandTrailGO.SetActive(true);
        }

        if (!OVRInput.Get(OVRInput.RawButton.LIndexTrigger) && leftHandTrailGO.activeInHierarchy == true)
        {
            if (leftHandTrail.time > 0)
            {
                leftHandTrail.time -= Time.deltaTime * fadeTime;
            }
        }

        if (OVRInput.Get(OVRInput.RawButton.LIndexTrigger) && leftHandTrailGO.activeInHierarchy == true)
        {
            leftHandTrail.time = 5f;
        }

        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger) && rightHandTrailGO.activeInHierarchy == false)
        {
            rightHandTrailGO.SetActive(true);
        }

        if (!OVRInput.Get(OVRInput.RawButton.RIndexTrigger) && rightHandTrailGO.activeInHierarchy == true)
        {
            if (rightHandTrail.time > 0)
            {
                rightHandTrail.time -= Time.deltaTime * fadeTime;
            }
        }

        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger) && rightHandTrailGO.activeInHierarchy == true)
        {
            rightHandTrail.time = 5f;
        }


    }

    /*
    public GameObject leftHandTrailGO;
    public GameObject rightHandTrailGO;

    // Start is called before the first frame update
    void Start()
    {
        leftHandTrailGO.SetActive(false);
        rightHandTrailGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Right hand
        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.7f)
        {
            if (rightHandTrailGO.activeInHierarchy == false)
            {
                rightHandTrailGO.SetActive(true);
            }
        }
        else if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) < 0.7f)
        {
            if (rightHandTrailGO.activeInHierarchy == true)
            {
                rightHandTrailGO.SetActive(false);

            }
        }

        // Right hand
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.7f)
        {
            if (leftHandTrailGO.activeInHierarchy == false)
            {
                leftHandTrailGO.SetActive(true);
            }
        }
        else if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) < 0.7f)
        {
            if (leftHandTrailGO.activeInHierarchy == true)
            {
                leftHandTrailGO.SetActive(false);

            }
        }

    }
    */
}
