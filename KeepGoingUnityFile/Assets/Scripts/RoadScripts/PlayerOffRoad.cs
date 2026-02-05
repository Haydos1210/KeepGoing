using UnityEngine;

public class PlayerOffRoad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameController.Instance.EndGame();
    }
}
