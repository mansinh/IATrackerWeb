using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MissionToken : MonoBehaviour, IPointerDownHandler
{ 
    [SerializeField] float duration;
    [SerializeField] Color activeColor;
    [SerializeField] Color inactiveColor;
 
    [SerializeField] Image image;
    bool active = false;

    private void Start()
    {
        image.color = inactiveColor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        StartCoroutine(FlipAnim());
    }


    public IEnumerator FlipAnim()
    {
       
        for (float i = 0; i <= 1; i += Time.deltaTime / duration)
        {
            transform.localEulerAngles = Vector3.up * i*90;
           
            yield return null;
        }
        if (active)
        {
            image.color = inactiveColor;
        }
        else
        {
            image.color = activeColor;
        }
        active = !active;
        for (float i = 1; i >=0; i -= Time.deltaTime / duration)
        {
            transform.localEulerAngles = Vector3.up * i * 90;
            
            yield return null;
        }
        transform.localEulerAngles = Vector3.zero;
    }
}
