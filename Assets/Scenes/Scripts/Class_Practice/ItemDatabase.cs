using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
   [SerializeField] Items Sword;
   [SerializeField] Items Hammer;
   [SerializeField] Items Bread;
   [SerializeField] Items[] items;
    void Start()
    {
        Sword = new Items();
        Sword.name = "Sword";
        Sword.id = 0;
        Sword.description = "SLASH SLASH";

        Hammer = new Items("Hammer",1,"Its a hammer");

        Bread = CreateItem("Bread", 2, "This is bread");

    }


    private Items CreateItem(string name, int id, string description) 
    {
        var items = new Items(name, id, description);
        return items;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
