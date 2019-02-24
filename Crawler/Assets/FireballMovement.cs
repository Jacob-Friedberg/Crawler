using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMovement : MonoBehaviour
{
    public int direction;
    private bool showstats;
    private bool finished = true; //change to false and uncomment for fun
    private Vector3 left = new Vector3(-8, 0), right = new Vector3(8, 0), up = new Vector3(0, 4), down = new Vector3(0, -4);
    private Vector3 upRight = new Vector3(7.4f, 4.3f), downRight = new Vector3(7.4f, -4.3f), downLeft = new Vector3(-7.4f, -4.3f), upLeft = new Vector3(-7.4f, 4.3f);
    // Start is called before the first frame update
    void Start()
    {
        showstats = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 whereto = left;
        switch (direction)
        {
            case 1:
                whereto = left;
                break;
            case 2:
                whereto = right;
                break;
            case 3:
                whereto = up;
                break;
            case 4:
                whereto = down;
                break;
            case 5:
                whereto = upLeft;
                break;
            case 6:
                whereto = upRight;
                break;
            case 7:
                whereto = downLeft;
                break;
            case 8:
                whereto = downRight;
                break;
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, whereto, Time.deltaTime);
        if (this.transform.position == whereto && finished)
        {
            Destroy(this.gameObject);
        } /*else if (this.transform.position == whereto)
        {
            switch(direction)
            {
                case 1:
                    direction = 5;
                    break;
                case 2:
                    direction = 8;
                    break;
                case 3:
                    direction = 6;
                    break;
                case 4:
                    direction = 7;
                    break;
            }
            finished = true;    

        }*/
    }
    public void SetTarget(int mydir)
    {
        direction = mydir;
    }
}
