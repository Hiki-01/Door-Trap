using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBurn : MonoBehaviour
{
    public int damage = 25;
    public ParticleSystem Fire;
    public List<ParticleCollisionEvent> collison;
    public AudioSource fire;
    void Start()
    {
        Fire = GetComponent<ParticleSystem>();
        collison = new List<ParticleCollisionEvent>();
        fire = gameObject.GetComponent<AudioSource>();
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().damage(damage);
        }
    }
}
