using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICT_error : MonoBehaviour
{
    public GameObject player; // reference to player character
    //public GameObject tool; // reference to the hammer tool from the chest
    public GameObject book;
    public string nameOfSprite; // the name of the character

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //when the player collide with the box
    //it will show his name
    //and pop the book out of the chest//
    void OnCollisionEnter2D(Collision2D col) 
    {
        
        nameOfSprite = player.GetComponent<SpriteRenderer>().sprite.name; 
        Debug.Log(nameOfSprite);

        Destroy(this); // kill the script component to prevent the box from making more than one hammer
        Destroy(gameObject);// remove the object from scene

        book.transform.position = new Vector2(-2,-2);
        
        
    }
}
