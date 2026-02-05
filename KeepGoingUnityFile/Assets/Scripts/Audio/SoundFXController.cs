using UnityEngine;

public class SoundFXController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private AudioSource soundFXObject;

    public static SoundFXController instance;
    private void Awake() => instance = this;

    // Plays sound fx clip at given transform
    public void PlaySoundFXClip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        AudioSource audioSource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        audioSource.clip = audioClip;

        audioSource.volume = volume;

        audioSource.Play();

        float clipLength = audioSource.clip.length;

        Destroy(audioSource.gameObject, clipLength);
    }
}
