using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public int damage = 25;
    public ParticleSystem Bomb;
    public List<ParticleCollisionEvent> collison;
    public AudioSource _bomb;
    void Start()
    {
        Bomb = GetComponent<ParticleSystem>();
        collison = new List<ParticleCollisionEvent>();
        _bomb = gameObject.GetComponent<AudioSource>();
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().damage(damage);
            _bomb.Play();
        }
    }
}
