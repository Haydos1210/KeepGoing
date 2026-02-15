using System.Collections;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SelectionCamController : MonoBehaviour
{
    private bool isMoving = false;
    private int offset = 10;

    public void MoveLeft()
    {
        Vector3 newPos = transform.position;
        newPos.x -= offset;
        transform.position = newPos;
    }

    public void MoveRight()
    {
        Vector3 newPos = transform.position;
        newPos.x += offset;
        transform.position = newPos;
    }

    public bool IsMoving()
    {
        return isMoving;
    }
}
