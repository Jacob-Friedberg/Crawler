using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float movespeed;
    public bool moveRight = true, moveLeft = true, moveUp = true, moveDown = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        if (Input.GetKey("d") && moveRight)
        {
            position.x += movespeed;
            this.transform.position = position;
        }
        if (Input.GetKey("s") && moveDown)
        {
            position.y -= movespeed;
            this.transform.position = position;
        }
        if (Input.GetKey("w") && moveUp)
        {
            position.y += movespeed;
            this.transform.position = position;
        }
        if (Input.GetKey("a") && moveLeft)
        {
            position.x -= movespeed;
            this.transform.position = position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Wall"))
        {
            if (collision.name.Contains("Right"))
            {
                moveRight = false;
            }
            if (collision.name.Contains("Left"))
            {
                moveLeft = false;
            }
            if (collision.name.Contains("Bottom"))
            {
                moveDown = false;
            }
            if (collision.name.Contains("Top"))
            {
                moveUp = false;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name.Contains("Wall"))
        {
            if (collision.name.Contains("Right"))
            {
                moveRight = true;
            }
            if (collision.name.Contains("Left"))
            {
                moveLeft = true;
            }
            if (collision.name.Contains("Bottom"))
            {
                moveDown = true;
            }
            if (collision.name.Contains("Top"))
            {
                moveUp = true;
            }
        }
    }
}
