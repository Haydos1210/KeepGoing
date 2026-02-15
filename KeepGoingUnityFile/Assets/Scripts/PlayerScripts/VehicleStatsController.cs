using UnityEngine;

public class VehicleStatsController : MonoBehaviour
{
    private float health;
    private float speed;
    public static VehicleStatsController Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void ApplyStats(CarData data)
    {
        speed = data.speed;
        health = data.health;
    }

    public float GetHealth()
    {
        return health;
    }

    public float GetSpeed()
    {
        return speed;
    }
}
