using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public float speed = 20f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed *Time.deltaTime;
        target = GameObject.FindGameObjectWithTag("Player").transform; //push
        transform.position = Vector2.MoveTowards(transform.position, target.position, step);
    }
}
