using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readInput : MonoBehaviour
{
    private string input;
    public GameObject scroll;
    string correctCode;
    string  code;
    public GameObject ICT_canvas;
    public GameObject reward; // blue gem as reward for 5 marks
    
    void Start()
    {
     correctCode = "x=5;"; // the required task is to declare a variable x=5;   
    }

    // Update is called once per frame
    void Update()
    {
        if(code == correctCode )
        {
            Debug.Log(code);
            Destroy(scroll);
            ICT_canvas.SetActive(false); // remove code editor from scene
            reward.transform.position = new Vector2(-1,-3);
        }
        
    }

    public void ReadStringInput(string input)
    {
        code = input;
    }
}
