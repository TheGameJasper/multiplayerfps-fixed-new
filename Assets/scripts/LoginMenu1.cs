using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DatabaseControl; // << Remember to add this reference to your scripts which use DatabaseControl
using UnityEngine.SceneManagement;

public class LoginMenu1 : MonoBehaviour {

    //These are the GameObjects which are parents of groups of UI elements. The objects are enabled and disabled to show and hide the UI elements.
    public GameObject loggedInParent;
    public Text usernameText;

    public GameObject loginMenu;

    //Scene Management
    public string loggedInSceneName = "Lobby";
    public string loggedOutSceneName = "LoginMenu";

    //These store the username and password of the player when they have logged in
    public string PlayerUsername = "";
    private string playerPassword = "";

    private void Awake()
    {
        loginMenu = GameObject.Find("Login Menu");
    }

    //Called at the very start of the game
    private void Start()
    {
        usernameText.text = "Logged In As: " + loginMenu.GetComponent<LoginMenu>().playerUsername;
    }

    public void LoggedIn_LogoutButtonPressed ()
    {
        //Called when the player hits the 'Logout' button. Switches back to Login UI and forgets the player's username and password.
        //Note: Database Control doesn't use sessions, so no request to the server is needed here to end a session.
        
        PlayerUsername = "";
        playerPassword = "";
        loggedInParent.gameObject.SetActive(false);
        SceneManager.LoadScene(loggedOutSceneName);
    }
}

