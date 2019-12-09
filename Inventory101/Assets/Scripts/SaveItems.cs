using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using SimpleJSON;

public class SaveItems : MonoBehaviour
{
   
    string user; 
    string ItemsTosave; 
    public GameObject alert;
    public RawImage saved;
    string s = "";

    private void Start()
    {
        user = dude.takeToNexScene; 
      
    }


    IEnumerator Save(string _items, string _username)
    {
       
        string createUserURL = "http://localhost:81/nsirpg/item/saveitems.php";
        WWWForm form = new WWWForm();
        form.AddField("items", _items);
        form.AddField("username", _username);

        UnityWebRequest webRequest = UnityWebRequest.Post(createUserURL, form);

        yield return webRequest.SendWebRequest();

        s = webRequest.downloadHandler.text;
        Debug.Log(s);
        if (s=="1")
        {
            Debug.Log("in");
            
            saved.gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("SaveIcon").GetComponent<RawImage>().CrossFadeAlpha(0, 0.75f, true);
            yield return new WaitForSeconds(0.75f);
            saved.gameObject.SetActive(false);


            
        }
        
    }

    public void StringifyTheItems()
    {
        ItemsTosave = ""; 
        for (int i = 0; i < LinearCanvasInventory.inv.Count; i++)
        {
            ItemsTosave += LinearCanvasInventory.inv[i].ID;
        }

      
        StartCoroutine(Save(ItemsTosave, user));
    }
}
