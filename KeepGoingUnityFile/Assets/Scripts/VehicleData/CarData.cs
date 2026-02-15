using UnityEngine;

[CreateAssetMenu(menuName = "Cars/Car Data")]
public class CarData : ScriptableObject
{
    public string carName;
    public GameObject prefab;
    public float speed;
    public float health;
}