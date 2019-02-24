using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public bool isShot = false;
    public bool correct = false;

    private GameObject circle;
    private GameObject diamond;


    // Start is called before the first frame update
    void Start()
    {
        isShot = false;
        correct = false;
        circle = GameObject.FindGameObjectWithTag("Circle");
        diamond = GameObject.FindGameObjectWithTag("Diamond");        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        this.isShot = true;
        if(!circle.GetComponent<Circle>().isShot && !diamond.GetComponent<Diamond>().isShot){
            this.correct = true;
        }
    }

    void OnCollisionEnter2D(Collider2D col){
        this.isShot = true;
        if(!circle.GetComponent<Circle>().isShot && !diamond.GetComponent<Diamond>().isShot){
            this.correct = true;
        }
    }

}
