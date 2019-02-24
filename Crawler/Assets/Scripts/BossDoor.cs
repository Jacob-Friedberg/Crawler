using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

      private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement player;
        
         if (collision.name == "Player" && player.hasKey)
        {
            print("this shit works");


        }
    }
}
