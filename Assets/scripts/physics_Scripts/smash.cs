using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smash : MonoBehaviour
{
    public ParticleSystem smashing;
    public GameObject hammer;
    public GameObject reward;
    Rigidbody2D rb; 
    public bool hammerDown;
    public bool hammerUp;
    SpriteRenderer sr;
    BoxCollider2D bc;
    public float counter;
    bool broken; 
    public GameObject player;
    Vector2 physics1_location;
    Vector2 currentLocation;
    public GameObject originalBrick;

    SpriteRenderer sr_originalBrick;
    Rigidbody2D rb_originalBrick;

    public static bool transported;

    void Start()
    {
      rb = hammer.GetComponent<Rigidbody2D>();
      hammerUp = true; // state of hammer upright at the beginning
      counter = 0; // number of hammer hits
      physics1_location = new Vector2(36,2); 
      
      transported = false;

       sr_originalBrick = originalBrick.GetComponent<SpriteRenderer>();
       rb_originalBrick = originalBrick.GetComponent<Rigidbody2D>();

      
      //smashing.GetComponents<ParticleSystem>().enableEmission = false;
    }

    void Awake()
    {
     
      smashing = GetComponentInChildren<ParticleSystem>();
      sr = GetComponent<SpriteRenderer>(); // sprite renderer of the brick to be smashed
      bc = GetComponent<BoxCollider2D>(); // box collider of the brick to be smashed
    }

    void Update()
    {
      currentLocation = player.transform.position;
      if(Input.GetKeyUp(KeyCode.Q) && transported == true)
      {
         // move the player to physics1 quest location instead of loading a new scene
        returnPlayerPosition();
      }


      if(currentLocation == physics1_location)
      {
        transported = true; // check if player was transported to quest location
        Debug.Log(transported);
      }
      else{transported = false;} // set transported bool o false in case player is back to villages

      if(transported == true) 
      {

        if (Input.GetKeyDown("space")  && counter < 5)
        {
          Debug.Log("Smash");
          hammer.transform.Rotate(0,0,-70);
          hammerDown = true;
          hammerUp = false;
          StartCoroutine(Break());
          counter = counter + 1;  
        }
        
        else if(Input.GetKeyUp("space") && counter < 5)
        {
          hammer.transform.Rotate(0,0,70);
          hammerUp = true;
          hammerDown = false;
        }

        if(counter >= 5)
        {
          broken = true;

          if(broken == true)
          {
            //sr_originalBrick.enabled = false;
            //rb_originalBrick.enabled = false;

            Destroy(originalBrick);
            
            
            sr.enabled = false; // disable the rendering of the smashed brick
            transported = false; // disable the 
            broken = false; // state of the brick to smash
            reward.transform.position = new Vector3(-2,6,0); // bring the red_gem as a reward inmain village
            returnPlayerPosition(); // return the player to main land

            Destroy(this);
          }
        
        }


      }
    }

    void FixedUpdate()
    {

    }

    void returnPlayerPosition()
    {
      player.transform.position = new Vector3(-2,5,0); // move the player to physics1 quest location instead of loading a new scene
      player.transform.localScale = new Vector3(1,1,1);
    }

    IEnumerator Break()
    {
      smashing.Play();

      //sr.enabled = false;
      //bc.enabled = false;

      yield return new WaitForSeconds(smashing.main.startLifetime.constantMax);

    }



    //void OnTriggerEnter2D(Collision other)
    //{
     // smashing.GetComponent<ParticleSystem>().enableEmission = true;
    //  StartCoroutine (stop());
   // }

    //IEnumerator stop()
    //{
     // yield return new WaitForSeconds(0.4f);
    //  smashing.GetComponents<ParticleSystem>().enableEmission = false;
   // }


}
