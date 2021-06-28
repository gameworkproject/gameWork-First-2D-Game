using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;

public class PlayfabManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;
    public Button registerButton;
    void Start()
    {   
        // Login();
        registerButton.onClick.AddListener(RegisterOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //trying out login via annonymous user
    // void Login() {
    //     var request = new LoginWithCustomIDRequest {
    //         CustomId = SystemInfo.deviceUniqueIdentifier,
    //         CreateAccount = true
    //     };
    //     PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    // }

    // void OnSuccess(LoginResult result){
    //     Debug.Log("Successful login/account create!");
    // }
    
    // void OnError (PlayFabError error){
    //     Debug.Log("error while logging in/creating account");
    //     Debug.Log(error.GenerateErrorReport());
    // }

    public void RegisterButton(){
        var request = new RegisterPlayFabUserRequest{
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }
    void RegisterOnClick()
    {
        Debug.Log("register button clicked");
        RegisterButton();
    }

    void OnRegisterSuccess(RegisterPlayFabUserResult result) {
        messageText.text = "Register Success!";
    }
    void OnError(PlayFabError error){
        messageText.text = "Failed to register";
        Debug.Log(error);
    }

    public void LoginButton(){

    }
    public void ResetPasswordButton(){

    }
}
