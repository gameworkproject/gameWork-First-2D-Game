using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class scroll_script : MonoBehaviour
{  //This script will check if the book has been collected, which will make colliding with the scroll
  // open a coding terminal for the student

    public GameObject book; // hammer to break the rocks
    public bool book_gone; // to check of codeBook was picked up by player
    public bool collided; //to check if player collided with scroll
    public GameObject player; // player reference
    public GameObject ICT_canvas; // the canvas where student will edit his code
    
    void Start()
    {
      
    }

    void Update()
    {
        if(book.activeSelf){}
        else
        {
            book_gone = true;
        }

        
    ////this funcion is replaced with the QUIT BUTTON in readInput.cs////
        //if(Input.GetKeyDown(KeyCode.Q)) // close the code editor for player
        //{
        //    ICT_canvas.SetActive(false);
       // }
    }
    
    void OnCollisionEnter2D(Collision2D col) // if player bumps into the scroll
    {
        collided = true;

        if(book_gone == true)             //if hammer was picked up by player
        {
            Debug.Log("welcome to CODE task");

            //open terminal with code to be edited
            ICT_canvas.SetActive(true);
        }

        else
        {
            collided = false;
            Debug.Log("go get your book");
        }
    }

}
