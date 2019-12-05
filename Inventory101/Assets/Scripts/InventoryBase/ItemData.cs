using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemID)
    {
        string _name = "";
        string _description = "";
        int _amount = 0;
        int _value = 0;
        ItemType _type = ItemType.Food;
        string _icon = "";
        string _mesh = "";
        int _damage = 0;
        int _armour = 0;
        int _heal = 0;
        switch(itemID)
        {
            #region Ingredient 0 -99
            case 0:
                _name = "Acorn";
                _description = "The acorn, or oaknut, is the nut of the oaks";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/Acorn";
                _mesh = "Ingredient/Acorn";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 1:
                _name = "Witches Hat Mushroom";
                _description = "A Mushroom that looks like a Witches hat and used to make potions";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/WHMroom";
                _mesh = "Ingredient/WHMroom";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 2:
                _name = "Barbed Tendril";
                _description = "Spikey Tendril";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/BarbedTendril";
                _mesh = "Ingredient/BarbedTendril";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
                #endregion
            #region  Potion 100 -199
            case 100:
                _name = "Acorn";
                _description = "The acorn, or oaknut, is the nut of the oaks";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/Acorn";
                _mesh = "Ingredient/Acorn";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 101:
                _name = "Witches Hat Mushroom";
                _description = "A Mushroom that looks like a Witches hat and used to make potions";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/WHMroom";
                _mesh = "Ingredient/WHMroom";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 102:
                _name = "Barbed Tendril";
                _description = "Spikey Tendril";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/BarbedTendril";
                _mesh = "Ingredient/BarbedTendril";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region  Scroll 200 -299
            case 200:
                _name = "Acorn";
                _description = "The acorn, or oaknut, is the nut of the oaks";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/Acorn";
                _mesh = "Ingredient/Acorn";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 201:
                _name = "Witches Hat Mushroom";
                _description = "A Mushroom that looks like a Witches hat and used to make potions";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/WHMroom";
                _mesh = "Ingredient/WHMroom";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 202:
                _name = "Barbed Tendril";
                _description = "Spikey Tendril";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/BarbedTendril";
                _mesh = "Ingredient/BarbedTendril";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region Food 300 -399
            case 300:
                _name = "Acorn";
                _description = "The acorn, or oaknut, is the nut of the oaks";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/Acorn";
                _mesh = "Ingredient/Acorn";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 301:
                _name = "Witches Hat Mushroom";
                _description = "A Mushroom that looks like a Witches hat and used to make potions";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/WHMroom";
                _mesh = "Ingredient/WHMroom";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 302:
                _name = "Barbed Tendril";
                _description = "Spikey Tendril";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/BarbedTendril";
                _mesh = "Ingredient/BarbedTendril";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region  Armour 400 -499
            case 400:
                _name = "Helm";
                _description = "Helm of the Dominator";
                _amount = 1;
                _value = 1;
                _type = ItemType.Armour;
                _icon = "Armour/IronHelm";
                _mesh = "Armour/IronHelm";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 401:
                _name = "Witches Hat Mushroom";
                _description = "A Mushroom that looks like a Witches hat and used to make potions";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/WHMroom";
                _mesh = "Ingredient/WHMroom";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 402:
                _name = "Barbed Tendril";
                _description = "Spikey Tendril";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/BarbedTendril";
                _mesh = "Ingredient/BarbedTendril";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region  Weapon 500 -599
            case 500:
                _name = "Sword";
                _description = "Pointy thingy";
                _amount = 1;
                _value = 10;
                _type = ItemType.Weapon;
                _icon = "Weapon/Sword";
                _mesh = "Weapon/Sword";
                _damage = 10;
                _armour = 0;
                _heal = 0;
                break;
            case 501:
                _name = "Axe";
                _description = "Chop Chop";
                _amount = 1;
                _value = 1;
                _type = ItemType.Weapon;
                _icon = "Weapon/Axe";
                _mesh = "Weapon/Axe";
                _damage = 15;
                _armour = 0;
                _heal = 0;
                break;
            case 502:
                _name = "Bow";
                _description = "Pew Pew";
                _amount = 1;
                _value = 1;
                _type = ItemType.Weapon;
                _icon = "Weapon/Bow";
                _mesh = "Weapon/Bow";
                _damage = 7;
                _armour = 0;
                _heal = 0;
                break;
                #endregion
            #region Craftable 600 - 699
            case 600:
                _name = "Acorn";
                _description = "The acorn, or oaknut, is the nut of the oaks";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/Acorn";
                _mesh = "Ingredient/Acorn";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 601:
                _name = "Witches Hat Mushroom";
                _description = "A Mushroom that looks like a Witches hat and used to make potions";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/WHMroom";
                _mesh = "Ingredient/WHMroom";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 602:
                _name = "Barbed Tendril";
                _description = "Spikey Tendril";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/BarbedTendril";
                _mesh = "Ingredient/BarbedTendril";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region Money 700 -799
            case 700:
                _name = "Acorn";
                _description = "The acorn, or oaknut, is the nut of the oaks";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/Acorn";
                _mesh = "Ingredient/Acorn";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 701:
                _name = "Witches Hat Mushroom";
                _description = "A Mushroom that looks like a Witches hat and used to make potions";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/WHMroom";
                _mesh = "Ingredient/WHMroom";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 702:
                _name = "Barbed Tendril";
                _description = "Spikey Tendril";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/BarbedTendril";
                _mesh = "Ingredient/BarbedTendril";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region  Quest 800 -899
            case 800:
                _name = "Acorn";
                _description = "The acorn, or oaknut, is the nut of the oaks";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/Acorn";
                _mesh = "Ingredient/Acorn";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 801:
                _name = "Witches Hat Mushroom";
                _description = "A Mushroom that looks like a Witches hat and used to make potions";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/WHMroom";
                _mesh = "Ingredient/WHMroom";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 802:
                _name = "Barbed Tendril";
                _description = "Spikey Tendril";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/BarbedTendril";
                _mesh = "Ingredient/BarbedTendril";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            #region  Misc 900 -999
            case 900:
                _name = "Acorn";
                _description = "The acorn, or oaknut, is the nut of the oaks";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/Acorn";
                _mesh = "Ingredient/Acorn";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 901:
                _name = "Witches Hat Mushroom";
                _description = "A Mushroom that looks like a Witches hat and used to make potions";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/WHMroom";
                _mesh = "Ingredient/WHMroom";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            case 902:
                _name = "Barbed Tendril";
                _description = "Spikey Tendril";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/BarbedTendril";
                _mesh = "Ingredient/BarbedTendril";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
            #endregion
            default:
                 itemID = 0;
                _name = "Acorn";
                _description = "The acorn, or oaknut, is the nut of the oaks";
                _amount = 1;
                _value = 1;
                _type = ItemType.Ingredient;
                _icon = "Ingredient/Acorn";
                _mesh = "Ingredient/Acorn";
                _damage = 0;
                _armour = 0;
                _heal = 0;
                break;
        }
        Item temp = new Item
        {
            ID = itemID,
            Name = _name,
            Description = _description,
            Amount = _amount,
            Value = _value,
            Type = _type,
            Icon = Resources.Load("Icons/" + _icon) as Texture2D,
            ItemMesh = Resources.Load("Mesh/" + _mesh) as GameObject,
            Damage = _damage,
            Armour = _armour,
            Heal = _heal
        };
        return temp;
    }
}
