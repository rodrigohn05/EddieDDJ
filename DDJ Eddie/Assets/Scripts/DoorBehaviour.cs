using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorBehaviour : MonoBehaviour
{
    public static int keys;
    public int scene;
    public Animator transitionAnim;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(gameObject.tag != "SpecialDoor"){
            if(collider.gameObject.tag == "Player")
            {
                StartCoroutine(LoadScene());
        
            }
        }else{
            if(TextKey.keys==3){
                if(collider.gameObject.tag == "Player")
                {
                    StartCoroutine(LoadScene());
        
                }
            }
            else{
                if(collider.gameObject.tag == "Player"){
                    GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3 (0,0,0);
                }
            }

        }
    }
    IEnumerator LoadScene(){
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(scene);
    }
}
