using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSound : MonoBehaviour
{
    [SerializeField] AudioSource mySource;
    [SerializeField] AudioClip scoreClips;

    private void Start()
    {
        mySource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pin"))
        {
            mySource.PlayOneShot(scoreClips);
        }
    }
}
