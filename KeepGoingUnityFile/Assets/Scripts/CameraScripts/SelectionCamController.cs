using System.Collections;
using TMPro;
using UnityEngine;

public class SelectionCamController : MonoBehaviour
{
    private bool isMoving = false;
    private int transitionSpeed = 20;
    private int offset = 10;
    public static SelectionCamController Instance;
    private void Awake() => Instance = this;
    public void MoveLeft()
    {
        Vector3 newPos = transform.position;
        newPos.x -= offset;
        StartCoroutine(SmoothMovement(newPos));
    }

    public void MoveRight()
    {
        Vector3 newPos = transform.position;
        newPos.x += offset;
        StartCoroutine(SmoothMovement(newPos));
    }

    IEnumerator SmoothMovement(Vector3 newPos)
    {
        isMoving = true;
        while (transform.position != newPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos, transitionSpeed * Time.deltaTime);

            yield return null;
        }

        transform.position = newPos;
        isMoving = false;
    }

    public bool IsMoving()
    {
        return isMoving;
    }
}
