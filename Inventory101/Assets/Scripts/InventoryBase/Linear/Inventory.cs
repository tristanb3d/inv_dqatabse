using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Linear
{
    public class Inventory : MonoBehaviour
    {
        public GUISkin invSkin;
        public GUIStyle boxStyle;
        #region Variables
        public List<Item> inv = new List<Item>();//list of items
        public Item selectedItem;
        public bool showInv;

        public Vector2 scr;
        public Vector2 scrollPos;

        public int money;

        public string sortType = "";

        public Transform dropLocation;
        [System.Serializable]
        public struct equipment
        {
            public string name;
            public Transform location;
            public GameObject curItem;
        };
        public equipment[] equipmentSlots;
        #endregion
        public ScrollRect view;
        public GameObject invButton;
        public RectTransform content;

        public Image icon;



        private void Start()
        {
            content.sizeDelta = new Vector2(292, 30);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            inv.Add(ItemData.CreateItem(0));
            inv.Add(ItemData.CreateItem(1));
            inv.Add(ItemData.CreateItem(2));
            inv.Add(ItemData.CreateItem(400));
            inv.Add(ItemData.CreateItem(500));
            inv.Add(ItemData.CreateItem(501));
            inv.Add(ItemData.CreateItem(502));
            for (int i = 0; i < inv.Count; i++)
            {
                GameObject Clone =  Instantiate(invButton, content);
                Clone.name = inv[i].Name;
                Clone.GetComponentInChildren<Text>().text = inv[i].Name;
            }
        }
        private void Update()
        {
            content.sizeDelta = new Vector2(0, 30 * inv.Count);

            if (Input.GetKey(KeyCode.I))
            {
                inv.Add(ItemData.CreateItem(Random.Range(0, 3)));
                GameObject Clone = Instantiate(invButton, content);
                Clone.name = inv[inv.Count-1].Name;
                Clone.GetComponentInChildren<Text>().text = inv[inv.Count - 1].Name;


            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                inv[4].Amount += 3;
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                showInv = !showInv;
                if (showInv)
                {
                    Time.timeScale = 0;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    return;
                }
                else
                {
                    Time.timeScale = 1;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    return;
                }
            }
        }

        private void OnGUI()
        {
            if (showInv)
            {
                //Make that more efficient by only calling when you need to
                scr.x = Screen.width / 16;
                scr.y = Screen.height / 9;

                GUI.Box(new Rect(0, 0, scr.x * 8, Screen.height), "");
                if (GUI.Button(new Rect(4f * scr.x, 0, scr.x, 0.25f * scr.y), "All"))
                {
                    sortType = "All";
                }
                if (GUI.Button(new Rect(5f * scr.x, 0, scr.x, 0.25f * scr.y), "Food"))
                {
                    sortType = "Food";
                }
                if (GUI.Button(new Rect(6f * scr.x, 0, scr.x, 0.25f * scr.y), "Armour"))
                {
                    sortType = "Armour";
                }
                if (GUI.Button(new Rect(7f * scr.x, 0, scr.x, 0.25f * scr.y), "Weapon"))
                {
                    sortType = "Weapon";
                }
                if (GUI.Button(new Rect(8f * scr.x, 0, scr.x, 0.25f * scr.y), "Ingredient"))
                {
                    sortType = "Ingredient";
                }
                Display();
                if (selectedItem != null)
                {
                    GUI.Box(new Rect(4.375f * scr.x, 0.25f * scr.y, 3 * scr.x, 0.25f * scr.y), selectedItem.Name, boxStyle);

                    GUI.skin = invSkin;
                    GUI.Box(new Rect(4.375f * scr.x, 0.5f * scr.y, 3 * scr.x, 3 * scr.y), selectedItem.Icon);

                    GUI.Box(new Rect(4.375f * scr.x, 3.5f * scr.y, 3 * scr.x, 3f * scr.y), selectedItem.Description);
                    GUI.skin = null;
                    ItemUse();

                }
                else
                { return; }

            }
        }
        void Display()
        {
            if (!(sortType == "All" || sortType == ""))
            {
                ItemType type = (ItemType)System.Enum.Parse(typeof(ItemType), sortType);
                int a = 0; // amount of that type
                int s = 0;//slot position
                for (int i = 0; i < inv.Count; i++)
                {
                    if (inv[i].Type == type)//find our type
                    {
                        a++;//increase for each item it finds
                    }
                }
                if (a <= 34)
                {
                    for (int i = 0; i < inv.Count; i++)
                    {
                        if (inv[i].Type == type)
                        {
                            if (GUI.Button(new Rect
                        (0.5f * scr.x, 0.25f * scr.y + s * (0.25f * scr.y),
                        3 * scr.x, 0.25f * scr.y), inv[i].Name))
                            {
                                selectedItem = inv[i];
                            }
                            s++;
                        }
                    }
                }
                else
                {
                    scrollPos = GUI.BeginScrollView(new Rect(0, 0.25f * scr.y, 3.75f * scr.x, 8.5f * scr.y), scrollPos, new Rect(0, 0, 0, 8.5f * scr.y + ((inv.Count - 34) * (0.25f * scr.y))), false, true);

                    for (int i = 0; i < inv.Count; i++)
                    {
                        if (inv[i].Type == type)
                        {
                            if (GUI.Button(new Rect
                        (0.5f * scr.x, 0 * scr.y + s * (0.25f * scr.y),
                        3 * scr.x, 0.25f * scr.y), inv[i].Name))
                            {
                                selectedItem = inv[i];
                            }
                            s++;
                        }
                    }
                    GUI.EndScrollView();
                }
            }
            else
            {
                if (inv.Count <= 34)//if we have 34 or less (space at top and bottom)
                {
                    for (int i = 0; i < inv.Count; i++)
                    {
                        if (GUI.Button(new Rect
                        (0.5f * scr.x, 0.25f * scr.y + i * (0.25f * scr.y),
                        3 * scr.x, 0.25f * scr.y), inv[i].Name))
                        {
                            selectedItem = inv[i];
                        }
                    }
                }
                else//more than 34 items
                {
                 //   our movable scroll position
                    scrollPos =
                 //   the start of our viewable area
                    GUI.BeginScrollView(
                 //   our View Window
                    new Rect(0, 0.25f * scr.y, 3.75f * scr.x, 8.5f * scr.y),
                  //  our current scroll position
                    scrollPos,
                   // scroll zone(extra space)
                    new Rect(0, 0, 0, 8.5f * scr.y + ((inv.Count - 34) * (0.25f * scr.y))),
                  //  can we see the horizontal bar ?
                    false,
                 //   can we see the vertical bar ?
                    true);

                    for (int i = 0; i < inv.Count; i++)
                    {
                        if (GUI.Button(new Rect
                        (0.5f * scr.x, 0 * scr.y + i * (0.25f * scr.y),
                        3 * scr.x, 0.25f * scr.y), inv[i].Name))
                        {
                            selectedItem = inv[i];
                        }
                    }

                  //  End the scroll space
                    GUI.EndScrollView();
                }
            }


        }
        void ItemUse()
        {
            switch (selectedItem.Type)
            {
                case ItemType.Ingredient:
                    break;
                case ItemType.Potion:
                    break;
                case ItemType.Scroll:
                    break;
                case ItemType.Food:
                    break;
                case ItemType.Armour:
                    if (equipmentSlots[0].curItem == null || selectedItem.Name != equipmentSlots[0].curItem.name)
                    {
                        if (GUI.Button(new Rect(4.75f * scr.x, 8 * scr.y, scr.x, 0.25f * scr.y), "Equip"))
                        {
                            if (equipmentSlots[0].curItem != null)
                            {
                                Destroy(equipmentSlots[1].curItem);
                            }
                            GameObject curItem = Instantiate(selectedItem.ItemMesh, equipmentSlots[0].location);
                            equipmentSlots[0].curItem = curItem;
                            curItem.name = selectedItem.Name;
                        }
                    }
                    else
                    {
                        if (GUI.Button(new Rect(4.75f * scr.x, 8 * scr.y, scr.x, 0.25f * scr.y), "Unequip"))
                        {
                            Destroy(equipmentSlots[0].curItem);
                        }
                    }
                    break;
                case ItemType.Weapon:
                    if (equipmentSlots[1].curItem == null || selectedItem.Name != equipmentSlots[1].curItem.name)
                    {
                        if (GUI.Button(new Rect(4.75f * scr.x, 8 * scr.y, scr.x, 0.25f * scr.y), "Equip"))
                        {
                            if (equipmentSlots[1].curItem != null)
                            {
                                Destroy(equipmentSlots[1].curItem);
                            }
                            GameObject curItem = Instantiate(selectedItem.ItemMesh, equipmentSlots[1].location);
                            equipmentSlots[1].curItem = curItem;
                            curItem.name = selectedItem.Name;
                        }
                    }
                    else
                    {
                        if (GUI.Button(new Rect(4.75f * scr.x, 8 * scr.y, scr.x, 0.25f * scr.y), "Unequip"))
                        {
                            Destroy(equipmentSlots[1].curItem);
                        }
                    }
                    break;
                case ItemType.Craftable:
                    break;
                case ItemType.Money:
                    break;
                case ItemType.Quest:
                    break;
                case ItemType.Misc:
                    break;
                default:
                    break;
            }
            if (GUI.Button(new Rect(6 * scr.x, 8 * scr.y, scr.x, 0.25f * scr.y), "Discard"))
            {
                for (int i = 0; i < equipmentSlots.Length; i++)
                {
                  //  check equiped items
                    if (equipmentSlots[i].curItem != null && selectedItem.Name == equipmentSlots[i].curItem.name)
                    {
                 //       if yea delete
                        Destroy(equipmentSlots[i].curItem);
                    }
                }
              //  Spawn in front
                GameObject droppedItem = Instantiate(selectedItem.ItemMesh, dropLocation.position, Quaternion.identity);

                droppedItem.name = selectedItem.Name;

                droppedItem.AddComponent<Rigidbody>().useGravity = true;
               // reduce or delete
                if (selectedItem.Amount > 1)
                {
                    selectedItem.Amount--;
                }
                else
                {
                    inv.Remove(selectedItem);
                    selectedItem = null;
                    return;
                }

            }
        }
    }

}
