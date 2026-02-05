using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("References")]
    public GameObject player;

    [Header("Vars")]
    private Vector3 offset;
    private Vector3 currCamPos;
    public static CameraController Instance { get; private set; }
    private void Awake() => Instance = this;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        transform.position = player.transform.position + offset;
        currCamPos = transform.position;
    }

    public static Vector3 GetCurrCamPos() => Instance.currCamPos;
}