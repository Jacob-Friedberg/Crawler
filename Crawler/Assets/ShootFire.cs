using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFire : MonoBehaviour
{
   
    public GameObject projectile;
    private bool alt = true, wait = false;
    private float timeelapsed = Time.time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!wait)
        {
            /*if (alt)
            {
                projectile.GetComponent<FireballMovement>().SetTarget(4);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(1);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(2);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(3);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                alt = false;
            } else
            {
                projectile.GetComponent<FireballMovement>().SetTarget(5);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(6);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(7);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                projectile.GetComponent<FireballMovement>().SetTarget(8);
                Instantiate(projectile, this.transform.position, Quaternion.identity);
                alt = true;
            }*/
            projectile.GetComponent<FireballMovement>().SetTarget(0);
            Instantiate(projectile, this.transform.position, Quaternion.identity);
            wait = true;
        } else
        {
            if (Time.time - timeelapsed > 0.1f)
            {
                wait = false;
                timeelapsed = Time.time;
            }
        }
    }
}
