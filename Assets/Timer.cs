using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float TimeSinceStart { get; set; } = 0;
    public static float timePerHour = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TimeSinceStart += Time.deltaTime;
    }
}
