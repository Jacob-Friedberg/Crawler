using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int health;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform; 
        float step = speed *Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, target.position, step);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Contains("Weapon")){
            health--;
        }
        if(health <= 0){
            Destroy(this.gameObject);
        }

    }
}
