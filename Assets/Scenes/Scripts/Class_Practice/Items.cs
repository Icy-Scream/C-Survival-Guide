using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Items
{
   public string name;
   public int id;
   public string description;
   public Sprite image;

    public Items(string name, int id, string description) //CONSTRUCTOR
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }

    public Items() { }
}
