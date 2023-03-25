using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public GameObject hide;
    public ParticleSystem explosive;
    public AudioSource bomb;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hide.SetActive(true);
        }
        if (other.gameObject.CompareTag("Target"))
        {
            explosive.Play();
            bomb.Play();
        }
    }
}
