using UnityEngine;

public class BasicCarStats : VehicleStats
{
    private float redCarHealth = 2000;
    private float redCarSpeed = 60;
    public override float GetVehicleHealth()
    {
        return redCarHealth;
    }

    public override float GetVehicleSpeed()
    {
        return redCarSpeed;
    }
}
