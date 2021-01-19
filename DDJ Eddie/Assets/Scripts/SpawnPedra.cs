using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPedra : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject pedraPrefab;
    
    
    
    void Update()
    {
        if(GameObject.Find("bolder1(Clone)") == null && GameObject.Find("bolder1") == null)
        {
        GameObject pedra = Instantiate(pedraPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }

}