using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class readInput : MonoBehaviour
{
    private string input;// variable to store student's input
    public GameObject scroll;
    string correctCode; // the required code in the task
    string  code; // vaiable to store the student input as code
    public GameObject ICT_canvas; // canvas where student input their code
    public GameObject reward; // blue gem as reward for 5 marks

    public Button SubmitButton; //  button to submit the code
    public Button QuitButton; // quit button to close the canvas and clear the code
    public InputField inputField; 
    public bool submitButtonPressed;

    
    void Start()
    {
        inputField.ActivateInputField();
        correctCode = "x=5;"; // the required task is to declare a variable x=5; 
        SubmitButton.onClick.AddListener(SubmitButtonHandler);  // execute the ENETR button function
        QuitButton.onClick.AddListener(QuitButtonHandler);  // execute the QUIT button function
    }

    void Update()
    {
        inputField.ActivateInputField();
        if(submitButtonPressed)
        {
            if(code == correctCode ) // check if the student's input is the correct code
            {
                Debug.Log("correct answer");
                Destroy(scroll); // remove scroll object when task is done
                ICT_canvas.SetActive(false); // remove code editor from scene
                reward.transform.position = new Vector2(-1,-3); // pop out the blue gem as reward for correct code
            }

            else
            {
                Debug.Log("ERROR");
            }

            submitButtonPressed = false;
        }
    }

    public void ReadStringInput(string input)
    {
        code = input;
    }

    public void SubmitButtonHandler() // function for the ENETR button
    {
        //Debug.Log("SUBMIT button pressed");
        submitButtonPressed = true;
    }


        public void QuitButtonHandler() // function for the QUIT button
    {
        Debug.Log("QUIT button pressed");
        input =""; // clear variable input
        code = ""; // clear variable stored as code
        inputField.text = ""; // clear the students code
        ICT_canvas.SetActive(false); // close the canvas
    }



}
