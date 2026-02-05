using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    private float speed = 60f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
