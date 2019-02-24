using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public bool isShot;
    public bool correct = false;

    public GameObject exit;

    private GameObject circle;
    private GameObject triangle;

    // Start is called before the first frame update
    void Start()
    {
        circle = GameObject.FindGameObjectWithTag("Circle");
        triangle = GameObject.FindGameObjectWithTag("Triangle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D col){
        isShot = true;
        if(triangle.GetComponent<Triangle>().correct && circle.GetComponent<Circle>().correct){
             Instantiate(exit, new Vector2(5.3f, 2.4f), Quaternion.identity);
        }
    }
}
