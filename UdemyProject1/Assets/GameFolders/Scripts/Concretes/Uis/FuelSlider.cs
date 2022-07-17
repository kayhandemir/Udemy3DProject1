using UnityEngine;
using UnityEngine.UI;
using UdemyProject1.Movements;

namespace UdemyProject1.Uis
{
    public class FuelSlider : MonoBehaviour
    {
        Slider _slider;
        Fuel _fuel;
        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _fuel = FindObjectOfType<Fuel>();
        }
        private void Update()
        {
            _slider.value = _fuel.CurretFuel;
        }
    }
}

