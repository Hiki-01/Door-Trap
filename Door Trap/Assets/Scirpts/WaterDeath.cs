using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDeath : MonoBehaviour
{
    public int damage = 25;
    public ParticleSystem Waterfall;
    public List<ParticleCollisionEvent> collison;
    public AudioSource WaterFall;
     void Start()
    {
        Waterfall = GetComponent<ParticleSystem>();
        collison = new List<ParticleCollisionEvent>();
        WaterFall = gameObject.GetComponent<AudioSource>();
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().damage(damage);
        }
    }
    
}
