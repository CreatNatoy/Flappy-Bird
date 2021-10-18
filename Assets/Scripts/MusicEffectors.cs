using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEffectors : MonoBehaviour
{
    [SerializeField] private AudioSource _audioEffectors;
    [SerializeField] private AudioClip _dieSound; 

    public void PlayDieSound()
    {
        _audioEffectors.PlayOneShot(_dieSound); 
    }
}
