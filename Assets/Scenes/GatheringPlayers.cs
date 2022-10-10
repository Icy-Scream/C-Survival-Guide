using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatheringPlayers : MonoBehaviour
{
    private GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        GatherAllPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void GatherAllPlayer()
{
    players = GameObject.FindGameObjectsWithTag("Player");

    foreach(var p in players)
    {
        p.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}

}
