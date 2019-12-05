using UnityEngine;

public class Item 
{
    #region Private Variables
    private int _id;
    private string _name;
    private string _description;
    private int _amount;
    private int _value;
    private ItemType _type;
    private Texture2D _icon;
    private GameObject _mesh;
    private int _damage;
    private int _armour;
    private int _heal;
    #endregion
    #region Public Properties
    public int ID
    {
        get { return _id; }//Read
        set { _id = value; }//Write
    }
    public string Name
    {
        get { return _name; }//Read
        set { _name = value; }//Write
    }
    public string Description
    {
        get { return _description; }//Read
        set { _description = value; }//Write
    }
    public int Amount
    {
        get { return _amount; }//Read
        set { _amount = value; }//Write
    }
    public int Value
    {
        get { return _value; }//Read
        set { _value = value; }//Write
    }
    public int Damage
    {
        get { return _damage; }//Read
        set { _damage = value; }//Write
    }
    public int Armour
    {
        get { return _armour; }//Read
        set { _armour = value; }//Write
    }
    public int Heal
    {
        get { return _heal; }//Read
        set { _heal = value; }//Write
    }
    public Texture2D Icon
    {
        get { return _icon; }//Read
        set { _icon = value; }//Write
    }
    public GameObject ItemMesh
    {
        get { return _mesh; }//Read
        set { _mesh = value; }//Write
    }
    public ItemType Type
    {
        get { return _type; }//Read
        set { _type = value; }//Write
    }

    #endregion
}
public enum ItemType
{
    Ingredient,
    Potion,
    Scroll,
    Food,
    Armour,
    Weapon,
    Craftable,
    Money,
    Quest,
    Misc
}
