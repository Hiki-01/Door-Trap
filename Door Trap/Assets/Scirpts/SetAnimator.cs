using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimator : MonoBehaviour
{
    public GameObject Anim1;
    public GameObject Anim2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Anim1.GetComponent<Animator>().enabled = true;
        }
    }

    public void Play()
    {
        Anim2.GetComponent<Animator>().enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Anim1.GetComponent<Animator>().enabled = false;
            Anim2.GetComponent<Animator>().enabled = false;
        }
    }
}
