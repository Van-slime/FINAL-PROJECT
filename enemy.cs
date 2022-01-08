using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
   
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

   private void OnTriggerEnter2D(Collider2D collision)
   {
       if(collision.tag == "Batas")
       {
           Destroy(this.gameObject);
       }
       else if(collision.tag == "Player")
       {
           Destroy(player.gameObject);
       }
}
}