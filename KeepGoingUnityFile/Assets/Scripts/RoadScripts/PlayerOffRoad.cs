using UnityEngine;

public class PlayerOffRoad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameController.Instance.EndGame();
        }
    }
}
