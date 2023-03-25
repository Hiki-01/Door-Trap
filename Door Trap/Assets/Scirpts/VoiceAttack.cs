using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().damage(50);
        }
    }
}
