using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float movespeed;
    public bool moveRight = true, moveLeft = true, moveUp = true, moveDown = true;
    public int health;
    public int attack;
    private static bool start = false;
    public bool hasKey;
    public Vector3 startLeft = new Vector3(-4.8f, 0.0f, 1.7f), startRight = new Vector3(4.8f, 0.0f, 1.6f), startTop = new Vector3(0.0f, 2.37f, 1.76f), startBottom = new Vector3(0.0f, -2.38f, 1.76f);
    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(this);
        health = 100;
        hasKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
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
        } else if (collision.name.Contains("Door"))
        {
            if (collision.name.Contains("Right") && !collision.name.Contains("Closed"))
            {
                this.transform.position = startLeft;
                moveRight = true;
                moveLeft = true;
                moveUp = true;
                moveDown = true;
            }
            if (collision.name.Contains("Left") && !collision.name.Contains("Closed"))
            {
                this.transform.position = startRight;
                moveRight = true;
                moveLeft = true;
                moveUp = true;
                moveDown = true;
            }
            if (collision.name.Contains("Top") && !collision.name.Contains("Closed"))
            {
                this.transform.position = startBottom;
                moveRight = true;
                moveLeft = true;
                moveUp = true;
                moveDown = true;
            }
            if (collision.name.Contains("Bottom") && !collision.name.Contains("Closed"))
            {
                this.transform.position = startTop;
                moveRight = true;
                moveLeft = true;
                moveUp = true;
                moveDown = true;
            }
        }
        else if (collision.name.Contains("Key"))
        {
            hasKey = true;
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
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
    static public void startGame()
    {
        start = true;
    }
}
