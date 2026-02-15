using System.Dynamic;
using UnityEngine;

public class VehicleSpawner: MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private CarData[] cars;

    private void Start()
    {
        int index = PlayerPrefs.GetInt("index");
        Debug.Log("Current index:" + index);
        CarData selectedCar = cars[index];
        GameObject newModel = selectedCar.prefab;
        newModel.tag = "Player";

        GameObject currentModel = player.transform.GetChild(0).gameObject;
        Transform currTransform = player.transform;

        Destroy(currentModel);
        currentModel = Instantiate(newModel, currTransform);

        VehicleStatsController.Instance.ApplyStats(selectedCar);
    }
}
