using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    private float speed;
    // Update is called once per frame
    private void Start()
    {
        speed = VehicleStatsController.Instance.GetSpeed();
    }
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
