using System.Collections;
using TMPro;
using UnityEngine;

public class SelectionCamController : MonoBehaviour
{
    private int transitionSpeed = 5;
    private int offset = 10;
    public static SelectionCamController Instance;
    private void Awake() => Instance = this;
    public void MoveLeft()
    {
        Vector3 newPos = transform.position;
        newPos.x -= offset;
        SmoothMovement(newPos);
    }

    public void MoveRight()
    {
        Vector3 newPos = transform.position;
        newPos.x += offset;
        SmoothMovement(newPos);
    }

    IEnumerator SmoothMovement(Vector3 newPos)
    {
        while (transform.position != newPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPos, transitionSpeed * Time.deltaTime);

            yield return null;
        }

        transform.position = newPos;
    }
}
