using UnityEngine;

public class VehicleStatsController : MonoBehaviour
{
    private VehicleStats vehicleStats;
    public static VehicleStatsController Instance;
    private void Awake()
    {
        Instance = this;
        vehicleStats = new BasicCarStats();
    }

    public void SetCarStats(VehicleStats diffVehicleStats)
    {
        vehicleStats = diffVehicleStats;
    }

    public float GetHealth()
    {
        return vehicleStats.GetVehicleHealth();
    }

    public float GetSpeed()
    {
        return vehicleStats.GetVehicleSpeed();
    }
}
