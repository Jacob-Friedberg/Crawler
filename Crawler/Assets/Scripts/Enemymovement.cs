using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public float speed;
    public Transform target;

    public GameObject exit;
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

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Contains("Arrow")){
            health--;
        }
        if(health <= 0){
            if(this.name.Contains("Ogre")){
                Instantiate(exit, new Vector2(5.3f, 2.4f), Quaternion.identity);
            }
            this.gameObject.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }
}
