using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CustomButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{


    [SerializeField] Image targetGraphic;
    [SerializeField] Color heldColor;
    [SerializeField] float holdTime = 1f;
    [SerializeField] TMP_Text text;
    [SerializeField] Button linkedButton;


    public UnityEvent onLongClick;
    public UnityEvent onClick;
    public UnityEvent onClickLinked;

    Color color;
    float timeHeld = 0f;
    bool pointerDown = false;
    bool linkedButtonHidden = true;

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
        targetGraphic.color = heldColor;
        StartCoroutine(DownTimer());
    }

    IEnumerator DownTimer()
    {
        while (pointerDown && timeHeld < holdTime)
        {
            timeHeld += Time.deltaTime;

            yield return null;
        }
        Activate();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDown = false;

    }

    void Activate()
    {
        pointerDown = false;
        targetGraphic.color = color;
        if (timeHeld < holdTime)
        {
            if (onClick != null)
            {
                print("click");
                onClick.Invoke();
            }
        }
        else
        {
            if (onLongClick != null)
            {
                print("long click");
                onLongClick.Invoke();
            }
        }
        timeHeld = 0;
    }

    public void SetText(string s)
    {
        if (text != null)
        {
            text.text = s;
        }
    }

    public void ShowLinkedButton()
    {
        if (linkedButton != null && linkedButtonHidden)
        {
            linkedButtonHidden = false;
            StartCoroutine(Functions.FadeIn(linkedButton.image, 0.2f));
        }
    }

    public void HideLinkedButton()
    {
        if (linkedButton != null && !linkedButtonHidden)
        {
            linkedButtonHidden = true;
            StartCoroutine(Functions.FadeOut(linkedButton.image, 0.2f));
        }
    }

    void OnClickLinked()
    {
        print("linked click");
        onClickLinked.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        color = targetGraphic.color;
        if (linkedButton != null)
        {
            linkedButton.onClick.AddListener(() => OnClickLinked());

        }
    }

}
