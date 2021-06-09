using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class rock_script : MonoBehaviour
{
    public GameObject hammer_2; // hammer to break the rocks
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hammer_2.GetComponent<Rigidbody2D>() == null)
        {
            Debug.Log("hammer gone");
        }
    }

    
}
