using UnityEngine;

public class RoadDetector : MonoBehaviour
{
    private float offset = 599.5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Road"))
        {
            other.transform.parent.position += offset * Vector3.forward;
        }
    }
}
