using TMPro;
using UnityEngine;
// Controls distance text(essentially speed of vehicle)
public class DistanceController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI distText;
    private float meters = 1;
    private float speed = 16;

    // Update is called once per frame
    void Update()
    {
        // update distance as long as game is active
        if (!GameController.Instance.GameOver())
        {
            UpdateDistance();
        } else
        {
            ResetDistance();
        }
        
    }

    void UpdateDistance()
    {
        distText.text = (meters += Time.deltaTime * speed).ToString("F0") + "m";
    }

    void ResetDistance()
    {
        distText.text = "0m";
    }
}
