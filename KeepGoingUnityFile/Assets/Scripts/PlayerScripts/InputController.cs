using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    [Header("Vars")]
    private InputAction move, sprint, jump, look;
    private float t = 0;

    [Header("References")]
    [SerializeField] private PlayerMovementController playerController;
    private CarControls carControls;
    private void Awake()
    {
        carControls = new CarControls();
    }
    private void OnEnable()
    {
        move = carControls.Player.Move;
        move.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveInput = move.ReadValue<Vector2>();
        playerController.MoveCar(moveInput, t);
        t += Time.deltaTime;
    }
}
