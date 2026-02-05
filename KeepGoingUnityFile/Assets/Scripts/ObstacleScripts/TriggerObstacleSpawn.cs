using UnityEngine;

public class TriggerObstacleSpawn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Road"))
        {

            SpawnObstacle scriptCall = other.GetComponent<SpawnObstacle>();
            if (scriptCall != null)
            {
                Debug.Log(other.gameObject.name);
                scriptCall.SpawnObstacles();
            }
        }
    }
}
