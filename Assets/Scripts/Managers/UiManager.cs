using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private HealthModule playerHealth;

    private void Awake()
    {
        playerHealth.OnHealthZero += ShowGameOver;
        playerHealth.OnHealthChanged += UpdateHealthValue;

    }
    void UpdateHealthValue(int currentHealth)
    {
        healthText.text = currentHealth.ToString() + "%";
    }

    public void ShowGameOver()
    {
        healthText.text = "YOU ARE DEAD!";
        healthText.color = Color.red;
    }
}




