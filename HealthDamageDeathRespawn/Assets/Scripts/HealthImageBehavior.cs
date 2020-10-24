using UnityEngine.UI;
using UnityEngine;
[RequireComponent(typeof(Image))]
public class HealthImageBehavior : MonoBehaviour
{
    private Image healthImage;
    public Gradient healthGradient;
    public FloatData health, maxHealth;

    private void Start()
    {
        healthImage = GetComponent<Image>();
    }

    private void Update()
    {
        healthImage.fillAmount = health.value / maxHealth.value;
        healthImage.color = healthGradient.Evaluate(health.value / maxHealth.value);
        
    }

}
