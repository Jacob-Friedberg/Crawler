using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float movespeed;
    public bool onWall;
    // Start is called before the first frame update
    void Start()
    {
        onWall = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        if (Input.GetKey("d"))
        {
            position.x += movespeed;
            this.transform.position = position;
        }
        if (Input.GetKey("s"))
        {
            position.y -= movespeed;
            this.transform.position = position;
        }
        if (Input.GetKey("w"))
        {
            position.y += movespeed;
            this.transform.position = position;
        }
        if (Input.GetKey("a"))
        {
            position.x -= movespeed;
            this.transform.position = position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Wall"))
        {
            print("fuck)");
            Vector3 position = this.transform.position;
            if (Input.GetKey("d"))
            {
                position.x -= movespeed;
                this.transform.position = position;
            }
            if (Input.GetKey("s"))
            {
                position.y += movespeed;
                this.transform.position = position;
            }
            if (Input.GetKey("w"))
            {
                position.y -= movespeed;
                this.transform.position = position;
            }
            if (Input.GetKey("a"))
            {
                position.x += movespeed;
                this.transform.position = position;
            }
        }
    }
}
