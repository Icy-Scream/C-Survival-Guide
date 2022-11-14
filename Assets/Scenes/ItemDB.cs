using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    [SerializeField] private List<Item> _itemsDB = new List<Item>();


    public void AddItem(int itemID, Player_Behavior player)
    {
        //check if the ID exist
        foreach(var item in _itemsDB) 
        { 
            if(itemID == item._id) //ID Exist ---> Get Player's Inventory and add item
            {
                Debug.Log("MATCH");
                player._inventory[0] = item;
                return;
            }
        }

        Debug.Log("Item Doesnt Not EXIST");
    }

    public void RemoveItem(int itemID,Player_Behavior player)
    {
        foreach (var item in _itemsDB)
        {
            if (itemID == item._id) //ID Exist ---> Get Player's Inventory and remove item
            {
                Debug.Log("MATCH");
                player._inventory[0] = null;
                return;
            }
        }
    }
}
