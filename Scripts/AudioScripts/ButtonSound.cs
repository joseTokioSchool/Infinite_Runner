using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    [SerializeField] AudioSource buttonSource;
    [SerializeField] AudioClip buttonClip;

    private void Start()
    {
        buttonSource = GetComponent<AudioSource>();
    }

    public void SoundButton()
    {
        buttonSource.PlayOneShot(buttonClip);
    }
}
