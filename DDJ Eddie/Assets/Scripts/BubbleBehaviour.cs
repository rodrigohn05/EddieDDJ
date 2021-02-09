using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleBehaviour : MonoBehaviour
{
    public static int countB1;
    public static int countB2;
    public static int countB3;
    public static int countB4;

    public static int geral=0;

    public GameObject prefab;

    void Start(){
        if(GameObject.FindGameObjectWithTag("Key1")==false && PlayerMovement.key2 == 0){
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        countB1 = CheckRaycastHit.countB1;
        countB2 = CheckRaycastHit.countB2;
        countB3 = CheckRaycastHit.countB3;
        countB4 = CheckRaycastHit.countB4;
        
        geral = countB1 + countB2 + countB3 + countB4;

        if (geral>=4){
            Destroy(gameObject);
        }
        //Debug.Log(geral);
    }
}
