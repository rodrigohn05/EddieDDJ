﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class PlayerAimWeapon : MonoBehaviour
{

   private Transform aimTransform;
   private Rigidbody2D rb;

   private void Awake()
   {
       
       aimTransform = transform.Find("Aim");
       rb = this.GetComponent<Rigidbody2D>();
   }

   private void Update(){
       Vector3 mousePosition = UtilsClass.GetMouseWorldPosition();
       
       Vector3 aimDirection = (mousePosition - transform.position).normalized;
       float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg -90f;
       rb.rotation = angle;
       aimTransform.eulerAngles = new Vector3(0,0,angle);
       
   }

   
}
