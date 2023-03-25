using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderDamge : MonoBehaviour
{
    public ParticleSystem Thunder;
    public List<ParticleCollisionEvent> collison;
    public AudioSource thunder;
    private void Start()
    {
        Thunder = GetComponent<ParticleSystem>();
        collison = new List<ParticleCollisionEvent>();
        thunder = gameObject.GetComponent<AudioSource>();
    }
    private void OnParticleCollision(GameObject other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().damage(50);
        }
    }
   
    
}
