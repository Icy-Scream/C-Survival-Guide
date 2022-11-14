using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behavior : MonoBehaviour
{
    [SerializeField] public Item[] _inventory = new Item[10];
    private ItemDB _itemDB;

    private void Start()
    {
        _itemDB = GameObject.Find("ItemDB").GetComponent<ItemDB>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        { 
            //Requesting Item from ITEMDB ---> Checks if it exist
            
            _itemDB.AddItem(0,this);
        }
        else if (Input.GetKey(KeyCode.R)) 
        {
            _itemDB.RemoveItem(0,this);
        }
    }
}
