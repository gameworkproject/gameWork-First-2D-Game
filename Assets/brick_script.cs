using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class brick_script : MonoBehaviour
{  //This script will check if the hammer has been collected, which will make colliding with the brick
  // move the player to the front scene (the task)

    public GameObject hammer_2; // hammer to break the rocks
    public bool hammer_gone;
    public bool collided;
    void Start()
    {
    }

    void Update()
    {
        if(hammer_2.activeSelf){}
        else
        {
            hammer_gone = true;
        }
    }
    
    void OnCollisionEnter2D(Collision2D col) 
    {
        collided = true;


        if(hammer_gone == true)
        {
            Debug.Log("welcome to task");
        }

        else
        {
            collided = false;
            Debug.Log("go see mr ragee");
        }
    }
    
}
