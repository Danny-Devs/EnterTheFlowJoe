using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectturneroffer : MonoBehaviour
{

    public GameObject self;
    public int time;

    void OnEnable()
    {
        StartCoroutine(Hide());
    }

    IEnumerator Hide()
    {
        yield return new WaitForSeconds(time);
        self.SetActive(false);
    }
}