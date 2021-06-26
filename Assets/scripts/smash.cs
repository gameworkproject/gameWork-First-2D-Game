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
    Vector3 physics1_location;
    Vector3 currentLocation;

    void Start()
    {
      rb = hammer.GetComponent<Rigidbody2D>();
      hammerUp = true;
      counter = 0;
      physics1_location = new Vector3(36,2,0);
      currentLocation = player.transform.position;
      

      //smashing.GetComponents<ParticleSystem>().enableEmission = false;
    }

    void Awake()
    {
      smashing = GetComponentInChildren<ParticleSystem>();
      sr = GetComponent<SpriteRenderer>();
      bc = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
      if(Input.GetKeyUp(KeyCode.Q))
      {
        player.transform.position = new Vector3(-2,5,0);; // move the player to physics1 quest location instead of loading a new scene
        player.transform.localScale = new Vector3(1,1,1);
      }

      if(currentLocation == physics1_location)
      {
        //player.GetComponent<CharacterController2D>().enabled = false;
      

        if (Input.GetKeyDown("space")  && counter < 5)
        {
          hammer.transform.Rotate(0,0,-70);//TODO leave to abdullah
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
         // sr.enabled = false;
          //return to main land
          //reward.transform.position = new Vector3(-2,5,0);
        }

        if(broken == true)
          {
            reward.transform.position = new Vector3(-2,6,0);
          }
      }
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
