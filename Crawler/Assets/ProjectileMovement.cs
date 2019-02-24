using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    private Vector3 targetloc;
    // Start is called before the first frame update
    void Start()
    {
        targetloc = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        position = Vector3.MoveTowards(position, targetloc, Time.deltaTime * 10);
        this.transform.position = position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.name.Contains("Player")){
            Destroy(this.gameObject); //test
        }
    }
}
