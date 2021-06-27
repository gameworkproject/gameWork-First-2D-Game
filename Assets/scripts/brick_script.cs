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
    
    void OnCollisionEnter2D(Collision2D col) 
    {
        collided = true;

        if(hammer_gone == true)
        {
            Debug.Log("welcome to task");
            //SceneManager.LoadScene(1);
            player.transform.position = physics1_location; // move the player to physics1 quest location instead of loading a new scene
            Debug.Log(player.transform.position);
            player.transform.localScale = new Vector3(3.5f,3.5f,3.5f);
            //sets variable to the smash script for physics to true, to allow smashing to begin
            smash.transported = true;
        }
        else
        {
            collided = false;
            Debug.Log("go see mr ragee");
        }
    }

}
