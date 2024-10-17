using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigZeiger : MonoBehaviour
{
    public bool isBigZeiger = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isBigZeiger)
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -Timer.TimeSinceStart * 360 / Timer.timePerHour);
        if (!isBigZeiger)
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -Timer.TimeSinceStart * 360 / Timer.timePerHour / 12);
    }
}
