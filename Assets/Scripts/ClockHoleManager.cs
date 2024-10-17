using UnityEngine;

public class ClockHoleManager : MonoBehaviour
{
    public Transform player;            // Reference to the player object
    public Transform clockCenter;       // Center of the clock
    public GameObject[] holes;          // Array to hold all hole GameObjects
    private int lastHourPassed = -1;    // Keep track of the last activated hour

    private void Update()
    {
        CheckForHourPass();
    }

    // Check if the player has passed an hour mark
    private void CheckForHourPass()
    {
        float angle = GetPlayerAngle();
        int currentHour = Mathf.FloorToInt(angle / 30f); // Each hour is 30 degrees

        // Activate the hole if the player just passed the hour mark
        if (currentHour != lastHourPassed)
        {
            if (currentHour >= 0 && currentHour < holes.Length)
            {
                ActivateHole(currentHour);
                lastHourPassed = currentHour; // Update the last hour passed
            }
        }
    }

    // Calculate the player's angle around the clock
    private float GetPlayerAngle()
    {
        Vector2 direction = (Vector2)player.position - (Vector2)clockCenter.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        return (angle + 360f) % 360f; // Normalize angle between 0 and 360
    }

    // Activate the hole at the given hour
    private void ActivateHole(int hour)
    {
        holes[hour].SetActive(true); // Activate the hole corresponding to the hour
    }
}
