using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class PlayfabManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        Login();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Login() {
        var request = new LoginWithCustomIDRequest {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    }

    void OnSuccess(LoginResult result){
        Debug.Log("Successful login/account create!");
    }
    
    void OnError (PlayFabError error){
        Debug.Log("error while logging in/creating account");
        Debug.Log(error.GenerateErrorReport());
    }

    public void RegisterButton(){
        var request = new RegisterPlayFabUserRequest{
            
        }
    }

    public void LoginButton(){

    }
    public void ResetPasswordButton(){

    }
}
