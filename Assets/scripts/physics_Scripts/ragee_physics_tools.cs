using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ragee_physics_tools : MonoBehaviour
{
    public GameObject player; // reference to player character
    //public GameObject tool; // reference to the hammer tool from the chest
    public GameObject hammer_2;
    public string nameOfSprite; // the name of the character

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //when the player collide with the box
    //it will show his name
    //and pop the hammer out of the chest//
    void OnCollisionEnter2D(Collision2D col) 
    {
        nameOfSprite = player.GetComponent<SpriteRenderer>().sprite.name;
        Debug.Log(nameOfSprite);// print in the consol

        //for hammer object prefab
        //GameObject hammer = Instantiate(tool) as GameObject;
        //hammer.transform.position = new Vector2(-2.5f,1.39f);// location of the hammer
        Destroy(this); // kill the script component to prevent the box from making more than one hammer
        Destroy(gameObject);
        //for hammer inventoryItem Collection
        hammer_2.transform.position = new Vector2( -2.5f,2.7f );
        
    }
}
