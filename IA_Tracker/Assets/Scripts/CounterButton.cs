using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CounterButton : MonoBehaviour
{
    int count = 0;
    [SerializeField] GameObject showCount;
    [SerializeField] Button minusButton;
    [SerializeField] bool hideMinusButton;

    TMP_Text showCountText;
    Image minusButtonImage;

    private void Start()
    {
        showCountText = showCount.GetComponent<TMP_Text>();
        minusButtonImage = minusButton.GetComponent<Image>();
        
    }

    public void Add()
    {
        
        count++;
        showCountText.text = "" + count;
        MinusButtonFadeIn();
    }

    public void Minus()
    {
        if (count > 0)
        {
            count--;
            showCountText.text = "" + count;
            MinusButtonFadeOut();
        }
    }

    void MinusButtonFadeIn()
    {
        if (hideMinusButton && count > 0) {
            StartCoroutine(Functions.FadeIn(minusButtonImage,0.2f));
        }
    }
    void MinusButtonFadeOut()
    {
        if (hideMinusButton && count <= 0)
        {
            StartCoroutine(Functions.FadeOut(minusButtonImage, 0.2f));
        }
    }


    
    


}
