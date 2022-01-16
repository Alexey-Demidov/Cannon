using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class SliderHandler : MonoBehaviour, IDragHandler 
{
    [Header("In pixels")]
    [SerializeField] private float _minPosition, _maxPosition;

    private float _left, _right;

    Vector2 _mousePos;
    RectTransform _transform;
    
    public void Start()
    {
        _minPosition = -280;
        _maxPosition =  90;
        _mousePos = new Vector2(transform.position.x, transform.position.y);
    }
    
    public void OnDrag(PointerEventData eventData)
    {
       
        _mousePos.x = eventData.position.x;

        //if (transform.position.x > _maxPosition)
        //    _mousePos.x = _maxPosition;
        //if (transform.position.x < _minPosition)
        //    _mousePos.x = _minPosition;

        transform.position = _mousePos;
        Debug.Log("handler position.x is " + transform.position.x);
    }
}
