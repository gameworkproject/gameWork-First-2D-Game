using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICT_chest : MonoBehaviour
{
    public GameObject player; // reference to player character
    //public GameObject tool; // reference to the hammer tool from the chest
    public GameObject book;
    public string nameOfSprite; // the name of the character


        // this script is attached to the ICT tool box
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
        book.transform.position = new Vector2(-2.5f,-2f); // codebook to appear out of toolbox 
        nameOfSprite = book.GetComponent<SpriteRenderer>().sprite.name; 
        Debug.Log(nameOfSprite);

        Destroy(this); // kill the script component to prevent the box from making more than one hammer
        Destroy(gameObject);// remove the object from scene

    }
}
