using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smash : MonoBehaviour
{
    public ParticleSystem smashing;
    public GameObject hammer;
    Rigidbody2D rb; 
    
    void Start()
    {
        rb = hammer.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)
    {
      smashing.Play();
    }
}
