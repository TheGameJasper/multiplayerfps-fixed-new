using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LoginMenu))]
public class UserAccount_Lobby : MonoBehaviour {

    public Text usernameText;

    private void Awake()
    {
        GameObject usernameText = GameObject.Find("LoggedInText");
        LoginMenu loginMenu = GetComponent<LoginMenu>();
    }

    private void Start()
    {

    }

}
