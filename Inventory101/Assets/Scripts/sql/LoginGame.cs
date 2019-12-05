using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginGame : MonoBehaviour
{
    public TMPro.TMP_InputField username;
    public TMPro.TMP_InputField password;
    public GameObject errortextpanel;
    public TextMeshProUGUI notification;
    //public TextMeshProUGUI text;
    IEnumerator LoginUser(string username, string password)
    {
        string loginUserURL = "http://localhost/nsirpg/loginuser.php";
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);
        if (username != null || password != null)
        {
            errortextpanel.gameObject.SetActive(true);
        }

        UnityWebRequest webRequest = UnityWebRequest.Post(loginUserURL, form);
        yield return webRequest.SendWebRequest();
        Debug.Log(webRequest.downloadHandler.text);

        if (webRequest.downloadHandler.text == "Login Successful")
        {
            SceneManager.LoadScene(1);
            //ChangeScene
            Debug.Log("Tots Works");
        }
        else
        {
            notification.text = webRequest.downloadHandler.text;
        }
    }
    public void StartGame()
    {
        StartCoroutine(LoginUser(username.text, password.text));
    }
}
