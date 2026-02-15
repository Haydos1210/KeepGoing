using UnityEngine;

public class ArmourCarStats : VehicleStats
{
    private float armourCarHealth = 10000;
    private float armourCarSpeed = 50;
    public override float GetVehicleHealth()
    {
        return armourCarHealth;
    }

    public override float GetVehicleSpeed()
    {
        return armourCarSpeed;
    }
}
