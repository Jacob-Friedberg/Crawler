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
                projectile.GetComponent<FireballMovement>().SetTarget(down);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(left);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(right);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(up);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                
            } else
            {
                projectile.GetComponent<FireballMovement>().SetTarget(upRight);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(downLeft);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(downRight);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(upLeft);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                
            }
            wait = true;
        } else
        {
            wait = false;
        }
    }
}
