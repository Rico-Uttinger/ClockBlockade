using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public int hour;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.TimeSinceStart / Timer.timePerHour > hour)
        {
            gameObject.GetComponent<CircleCollider2D>().enabled = true;
            gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
        }
    }
}
