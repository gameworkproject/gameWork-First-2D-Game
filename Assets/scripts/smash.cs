using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class smash : MonoBehaviour
{
    public ParticleSystem smashing;
    public GameObject hammer;
    Rigidbody2D rb; 
    public bool hammerDown;
    public bool hammerUp;
    SpriteRenderer sr;
    BoxCollider2D bc;
    float counter;

    
    void Start()
    {
      counter = 0;
      rb = hammer.GetComponent<Rigidbody2D>();
      hammerUp = true;

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
      if (Input.GetKeyDown("space"))
      {
         hammer.transform.Rotate(0,0,-70);
         hammerDown = true;
         hammerUp = false;
         StartCoroutine(Break());
 
         //smashing.enableEmission = true;
      }
      else if(Input.GetKeyUp("space"))
      {
        hammer.transform.Rotate(0,0,70);
        hammerUp = true;
        hammerDown = false;
        counter = counter +1;
      }
      if(counter >= 5)
      {
        SceneManager.LoadSceneAsync(0);
      }  
    }

    IEnumerator Break()
    {
      smashing.Play();

      //sr.enabled = false;
      //bc.enabled = false;

      yield return new WaitForSeconds(smashing.main.startLifetime.constantMax);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
      Debug.Log("hits");
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
