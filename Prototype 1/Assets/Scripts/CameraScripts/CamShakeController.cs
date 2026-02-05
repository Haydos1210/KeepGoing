using System.Collections;
using UnityEngine;
using DG.Tweening;

public class CamShakeController : MonoBehaviour
{
    public static CamShakeController Instance;

    private Vector3 originalLocalPos;

    void Awake()
    {
        Instance = this;
        originalLocalPos = transform.localPosition;
    }

    private void Shake(float strength, float duration)
    {
        StopAllCoroutines();
        StartCoroutine(ShakeRoutine(strength, duration));
    }

    public static void ShakeCamera(float strength, float duration) => Instance.Shake(strength, duration);

    private IEnumerator ShakeRoutine(float strength, float duration)
    {
        float elapsed = 0f;

        while (elapsed < duration)
        {
            Vector3 offset = Random.insideUnitSphere * strength;
            transform.localPosition = originalLocalPos + offset;

            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = originalLocalPos;
    }
}
