using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using UnityEngine.SceneManagement;

public class brick_script : MonoBehaviour
{  //This script will check if the hammer has been collected, which will make colliding with the brick
  // move the player to the front scene (the task)

    public GameObject hammer_2; // hammer to break the rocks
    public bool hammer_gone;
    public bool collided;
    public GameObject player;
    Vector3 physics1_location;
    
    void Start()
    {
        physics1_location = new Vector3(36,2,0);
    }

    void Update()
    {
        if(hammer_2.activeSelf){}
        else
        {
            hammer_gone = true;
        }
    }
    
    void OnCollisionEnter2D(Collision2D col) // if player bumps into the origial brick
    {
        collided = true;

        if(hammer_gone == true)             //if hammer was picked up by player
        {
            Debug.Log("welcome to task");
            player.transform.position = physics1_location; // move the player to physics1 quest location instead of loading a new scene
            player.transform.localScale = new Vector3(3.5f,3.5f,3.5f);

            //turn off character controller
        }

        else
        {
            collided = false;
            Debug.Log("go get your tools");
        }
    }

}
