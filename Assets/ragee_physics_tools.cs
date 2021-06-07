using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ragee_physics_tools : MonoBehaviour
{
    public GameObject player;
    public string nameOfSprite;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        nameOfSprite = player.GetComponent<SpriteRenderer>().sprite.name;
        Debug.Log(nameOfSprite);
    }
}
