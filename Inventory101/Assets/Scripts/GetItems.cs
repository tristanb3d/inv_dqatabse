using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

using System.Linq;

public class GetItems : MonoBehaviour
{

    string user;
    public GameObject buttonPrefab;
    public RectTransform parent;
    string httpheader = "";
    public string[] returnedItems;

    #region Internal
    void Start()
    {
        
        user = myGuy.takeToNexScene;
        InitiateGetItems();
    }

    void Update()
    {

    }
    #endregion

    #region External
    public IEnumerator GetAllItems(string _username)
    {
      
        string createUserURL = "http://localhost:81/nsirpg/item/GetItem.php";
        WWWForm form = new WWWForm();
        form.AddField("username", _username);

        

        UnityWebRequest webRequest = UnityWebRequest.Post(createUserURL, form);

        yield return webRequest.SendWebRequest();

      

        httpheader = webRequest.downloadHandler.text;
        if (httpheader.Length > 3)
        {
            returnedItems = Split(httpheader, 3).ToArray();


            for (int i = 0; i < returnedItems.Length; i++)
            {
                int id = 0;
                if (!int.TryParse(returnedItems[i], out id))
                {
                   
                }

                LinearCanvasInventory.inv.Add(ItemData.CreateItem(id));
                int currentSlot = LinearCanvasInventory.inv.Count - 1;
                GameObject button = Instantiate(buttonPrefab, parent) as GameObject; 
                button.GetComponent<SelectButton>().index = currentSlot;
                button.name = LinearCanvasInventory.inv[currentSlot].Name;
                button.GetComponentInChildren<Text>().text = LinearCanvasInventory.inv[currentSlot].Name;
            }
        }
    }

    public void InitiateGetItems()
    {
      
        StartCoroutine(GetAllItems(user));
    }

    static IEnumerable<string> Split(string str, int cSize)
    {
        return Enumerable.Range(0, str.Length / cSize)
            .Select(i => str.Substring(i * cSize, cSize));
    }
    #endregion
}
