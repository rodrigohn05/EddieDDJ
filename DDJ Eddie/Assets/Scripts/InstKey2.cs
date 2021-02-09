using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstKey2 : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Key1")==false && PlayerMovement.key2 == 0){
            Instantiate(prefab, new Vector3(-18.73f,6.06f,0f), transform.rotation);
        }
    }

  
}
