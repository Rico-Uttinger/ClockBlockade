using UnityEngine;

public class HoleSpawner : MonoBehaviour
{
    public GameObject holePrefab; // Prefab of the hole to be spawned
    public int initialHoleCount = 1; // Starting number of holes
    public float clockRadius = 5f; // The radius of the clock
    private int currentHoleCount;
    public Transform clockCenter; // Center of the clock (could be set to (0,0))

    void Start()
    {
        currentHoleCount = initialHoleCount;
        SpawnHoles(currentHoleCount); // Spawn initial holes
    }

    // Call this method when the player passes an hour
    public void SpawnMoreHoles()
    {
        currentHoleCount++;
        SpawnHoles(currentHoleCount); // Increase the number of holes
    }

    // Spawns a given number of holes at random positions along the clock's perimeter
    private void SpawnHoles(int count)
    {
        for (int i = 0; i < count; i++)
        {
            float randomAngle = Random.Range(0f, 360f); // Random angle around the circle
            Vector2 spawnPosition = GetPositionOnCircle(randomAngle);
            Instantiate(holePrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Converts an angle in degrees to a position on the clock's circumference
    private Vector2 GetPositionOnCircle(float angleInDegrees)
    {
        float angleInRadians = angleInDegrees * Mathf.Deg2Rad; // Convert degrees to radians
        float x = clockCenter.position.x + clockRadius * Mathf.Cos(angleInRadians);
        float y = clockCenter.position.y + clockRadius * Mathf.Sin(angleInRadians);
        return new Vector2(x, y);
    }
}
