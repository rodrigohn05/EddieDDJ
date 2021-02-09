using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public static int restart;
    public static int pa;

    public void Setup(){
        gameObject.SetActive(true);
        pa=0;
        restart=0;
    }

    void Update(){
        pa=0;
        restart=0;
    }

    public void Restart(){
        SceneManager.LoadScene(1);
        pa = 1;
    }

    public void RestartBegin(){
        SceneManager.LoadScene(1);
        pa=1;
        restart = 1;
    }
}
