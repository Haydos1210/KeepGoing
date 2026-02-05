using TMPro;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [Header("Vars")]
    private float maxHealth = 2500;
    private float health;
    [SerializeField] private TextMeshProUGUI healthText;
    public static HealthController Instance;
    void Awake() => Instance = this;

    private void Start()
    {
        healthText.text = maxHealth.ToString();
        health = maxHealth;
    }

    public void SubtractHealth(float damage)
    {
        // subtract current health variable
        health -= damage;

        if (health <= 0)
        {
            // Change text at top right to match new health(make health 0)
            healthText.text = "0";
            //End game
            GameController.Instance.EndGame();
            ResetHealth();
            //Exit
            return;
        }

        // Change text at top right
        healthText.text = health.ToString();
    }

    // TODO: depending on vehicle, reset health to full
    public void ResetHealth()
    {
        health = maxHealth;
    }

    // TODO: AddHealth function for powerups -  maybe make new script for powerups(powerups class)
}
