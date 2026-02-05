using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private float[] xCoords = {-3f, 2.5f, 8f};
    [SerializeField] private Transform obsParent;

    public void SpawnObstacles()
    {
        GameObject obstacle = obstacles[Random.Range(0, obstacles.Length)];
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            //float xCoord = xCoords[Random.Range(0, xCoords.Length)];
            float xCoord = Random.Range(-9, 9);
            float yCoord = spawnPoints[i].position.y;
            float zCoord = spawnPoints[i].position.z;
            Instantiate(obstacle, new Vector3(xCoord, yCoord, zCoord), Quaternion.identity, obsParent);
        }
    }
}
