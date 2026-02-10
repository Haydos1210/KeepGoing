using UnityEngine;

public class BasicCarStats : VehicleStats
{
    public override float GetVehicleHealth()
    {
        return 2000;
    }

    public override float GetVehicleSpeed()
    {
        return 60;
    }
}
