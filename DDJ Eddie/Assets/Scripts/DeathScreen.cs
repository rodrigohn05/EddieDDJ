﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public void Setup(){
        gameObject.SetActive(true);
    }

    public void Restart(){
        SceneManager.LoadScene(1);
    }
}
