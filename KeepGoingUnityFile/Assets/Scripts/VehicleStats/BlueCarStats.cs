using UnityEngine;

public class BlueCarStats : VehicleStats
{
    private float blueCarHealth = 3000;
    private float blueCarSpeed = 70;
    public override float GetVehicleHealth()
    {
        return blueCarHealth;
    }

    public override float GetVehicleSpeed()
    {
        return blueCarSpeed;
    }
}
