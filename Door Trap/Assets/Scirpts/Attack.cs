using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private int ata = 25;
    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerHealth>().damage(ata);
    }
}
