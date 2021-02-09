using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayer : MonoBehaviour
{
    public GameObject playerPrefab;
    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Player") == false){
            Instantiate(playerPrefab, transform.position, transform.rotation);
        }
    }


}
