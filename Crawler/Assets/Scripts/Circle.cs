using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public bool isShot = false;

    public bool correct = false;

    private GameObject triangle;

    private GameObject diamond;
    // Start is called before the first frame update
    void Start()
    {
        isShot = false;
        correct = false;
        triangle = GameObject.FindGameObjectWithTag("Triangle");
        diamond = GameObject.FindGameObjectWithTag("Diamond");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D col){
        this.isShot = true;
        if(triangle.GetComponent<Triangle>().correct && !diamond.GetComponent<Diamond>().isShot){
            this.correct = true;
        }
    }
}
