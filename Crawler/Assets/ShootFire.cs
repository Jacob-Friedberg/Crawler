using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFire : MonoBehaviour
{
    private Vector3 left = new Vector3(-8, 0), right = new Vector3(8, 0), up = new Vector3(0, 4), down = new Vector3(0, -4);
    private Vector3 upRight = new Vector3(7.4f, 4.3f), downRight = new Vector3(7.4f, -4.3f), downLeft = new Vector3(-7.4f, -4.3f), upLeft = new Vector3(-7.4f, 4.3f);
    public GameObject projectile;
    private bool alt = true, wait = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!wait)
        {
            if (alt)
            {
                Instantiate(projectile, left, Quaternion.identity);
                Instantiate(projectile, right, Quaternion.identity);
                Instantiate(projectile, down, Quaternion.identity);
                Instantiate(projectile, up, Quaternion.identity);
            } else
            {
                Instantiate(projectile, upRight, Quaternion.identity);
                Instantiate(projectile, upLeft, Quaternion.identity);
                Instantiate(projectile, downLeft, Quaternion.identity);
                Instantiate(projectile, downRight, Quaternion.identity);
            }
        } else
        {
            wait = false;
        }
    }
}
