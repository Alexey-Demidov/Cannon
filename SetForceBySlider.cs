using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class SetForceBySlider : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Slider _slider;
    public bool NotDragging { get; private set; }

    public void Start()
    {
        NotDragging = true;
        _slider = GetComponent<Slider>();
        ShotParametrs.forceZ = _slider.minValue;       
    }

    public void SetForce() => ShotParametrs.forceZ = _slider.value;

    public void OnPointerDown(PointerEventData eventData) => NotDragging = false;

    public void OnPointerUp(PointerEventData eventData) => NotDragging = true;
}
