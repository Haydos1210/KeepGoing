using UnityEngine;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform carVisual;
    [SerializeField] private Transform orientation;
    private Rigidbody rb;

    [Header("Vars")]
    private float speed = 20.0f;
    private float turnSpeed = 20f;
    float currentTilt;
    [SerializeField] float tiltSmooth = 5f;
    private float shakeDuration = 0.3f;
    private float shakeStrengthAdjustment = 0.1f;
    private float convToHealth = 250;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public void MoveCar(Vector3 moveInput, float tSpeed)
    {
        Vector3 newPos = orientation.right * moveInput.x;
        newPos = newPos * Time.deltaTime * speed;
        rb.MovePosition(newPos + rb.position);

        float targetTilt = moveInput.x * turnSpeed;
        currentTilt = Mathf.Lerp(currentTilt, targetTilt, Time.fixedDeltaTime * tiltSmooth);
        carVisual.localRotation = Quaternion.Euler(0f, currentTilt, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Obstacle") && collision.gameObject.CompareTag("Obstacle"))
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            float shakeStrength = collision.gameObject.GetComponent<Rigidbody>().mass * shakeStrengthAdjustment;
            Debug.Log("shakeStrength: " + shakeStrength);
            CamShakeController.ShakeCamera(shakeStrength, shakeDuration);
            float healthLost = shakeStrength * convToHealth;
            HealthController.Instance.SubtractHealth(healthLost);
            // TODO: damage handling(health and smoke animation) => ui for health
        }
    }
}
