using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customers
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Gender;
    public string Occupation;

    public Customers(string firstName, string lastName, int age, string gender, string occupation)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Gender = gender;
        Occupation = occupation;
    }
}
