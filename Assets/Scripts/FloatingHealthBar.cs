using UnityEngine;
using UnityEngine.UI;
public class FloatingHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void UpdateHealth(float currentValue, float maxValue)
    {
        _slider.value = currentValue / maxValue;
    }
}