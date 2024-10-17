using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float TimeSinceStart { get; set; } = 0;
    public static float timePerHour = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            TimeSinceStart += Time.deltaTime * 1.5f;
        }
        else
        {
            TimeSinceStart += Time.deltaTime;
        }
    }
}
