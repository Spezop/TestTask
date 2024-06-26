using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollObjectDeleteOnClick : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
    }
}