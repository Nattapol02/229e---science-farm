using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   private int Enemy;

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.transform.tag == "Enemy")
      {
         Enemy++;
         Debug.Log(Enemy);
         Destroy(other.gameObject);
      }
      Destroy(gameObject);
   }
}
