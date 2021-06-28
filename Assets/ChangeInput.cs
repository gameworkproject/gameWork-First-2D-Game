using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeInput : MonoBehaviour
{
    EventSystem system;
    //indicate which element is the first that is automatically selected
    public Selectable firstInput;
    //link to login button to allow the use of enter/return for login
    public Button submitButton;
    // Start is called before the first frame update
    void Start()
    {
        system = EventSystem.current;   
        firstInput.Select();
    }

    // Update is called once per frame
    void Update()
    {
        //allows user to switch through entries in the login/register form using the tab key
        if(Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift)){
            Selectable previous = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
            if (previous != null){
                previous.Select();
            }
        }
        else if(Input.GetKeyDown(KeyCode.Tab)){
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
            if (next != null){
                next.Select();
            }
        }
        else if(Input.GetKeyDown(KeyCode.Return)){
            submitButton.onClick.Invoke();
            Debug.Log("Button Pressed");
        }

    }
}
