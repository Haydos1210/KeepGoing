using UnityEngine;

public class GreenVanStats : VehicleStats
{
    private float greenVanHealth = 5000;
    private float greenVanrSpeed = 60;
    public override float GetVehicleHealth()
    {
        return greenVanHealth;
    }

    public override float GetVehicleSpeed()
    {
        return greenVanrSpeed;
    }
}
