using UnityEngine;

public class BlueBusStats : VehicleStats
{
    private float busHealth = 7500;
    private float busSpeed = 40;
    public override float GetVehicleHealth()
    {
        return busHealth;
    }

    public override float GetVehicleSpeed()
    {
        return busSpeed;
    }
}
