using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTrack : MonoBehaviour
{
    string mytext;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        int health = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().getHealth();
        mytext = "Health: \n " + health;
        Text text = this.GetComponent<Text>();
        text.text = mytext;
    }
}
