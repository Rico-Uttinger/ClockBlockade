using UnityEngine;

public class ObsoleteGameManager : MonoBehaviour
{
    public ObsoleteHoleSpawner holeSpawner; // Reference to the HoleSpawner
    public int hoursPassed = 0;
    public Transform player;
    public Transform clockCenter;
    
    private float lastPlayerAngle = 0f;

    void Update()
    {
        float currentAngle = GetPlayerAngleAroundClock();
        
        // Check if the player has completed one full loop around the clock
        if (HasCompletedFullCircle(lastPlayerAngle, currentAngle))
        {
            hoursPassed++;
            holeSpawner.SpawnMoreHoles(); // Spawn additional holes
            Debug.Log("Hour Passed: " + hoursPassed);
        }
        
        lastPlayerAngle = currentAngle;
    }

    private float GetPlayerAngleAroundClock()
    {
        Vector2 direction = player.position - clockCenter.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        return (angle + 360f) % 360f; // Normalize angle to be between 0 and 360
    }

    private bool HasCompletedFullCircle(float previousAngle, float currentAngle)
    {
        // Assuming player moves clockwise, check if they've crossed the 0 degree line
        return previousAngle > 300f && currentAngle < 60f; // 60-degree tolerance to detect crossing
    }
}
