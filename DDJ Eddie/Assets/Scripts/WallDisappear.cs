using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDisappear : MonoBehaviour
{
    public static int key2=0;
    void Update()
    {
        if(PlayerMovement.key2 == 1){
            Destroy(gameObject);
        }
    }
}
