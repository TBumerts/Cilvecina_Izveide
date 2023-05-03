using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ApgerbuDrag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform transformKomponente;
    public Canvas kanva;
    void start() {
        transformKomponente = GetComponent<RectTransform>();
    }
    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Izdarīts peles klikškis uz objekta!");

    }
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsākta objekta vilkšana!");
    }
    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Notiek objekta pārvietošana!");
        transformKomponente.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }
    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Objekta pārvietošana beigta!");
    }
}