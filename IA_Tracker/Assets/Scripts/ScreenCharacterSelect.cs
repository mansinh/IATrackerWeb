using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenCharacterSelect : MonoBehaviour
{
    [SerializeField] Transform listLayout;
    [SerializeField] GameObject characterSelectButtonPrefab;
    [SerializeField] Image scrollbarHandle;
    [SerializeField] Image scrollbarSlider;

    List<GameObject> characterButtons = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
      

        Sprite[] characterButtonImages = Functions.GetSprites("Images/UI/CharacterSelect");
        
        for (int i = 0; i < characterButtonImages.Length; i++)
        {
            print(i);
            GameObject characterSelectButton  = Instantiate(characterSelectButtonPrefab, listLayout);
            characterSelectButton.name = i + "";
            characterSelectButton.GetComponent<Button>().onClick.AddListener(() => Select(int.Parse(characterSelectButton.name)));
            characterSelectButton.GetComponentInChildren<Image>().sprite = characterButtonImages[i];

            characterButtons.Add(characterSelectButton);

             
        }
        StartCoroutine(TransitionIn());
    }

    IEnumerator TransitionIn() {
        
        StartCoroutine(Functions.FadeIn(scrollbarHandle, 0.5f));
        StartCoroutine(Functions.FadeIn(scrollbarSlider, 0.5f));

        for (int i = 0; i < characterButtons.Count; i++) 
        {
            StartCoroutine(Functions.FadeIn(characterButtons[i].GetComponentInChildren<Image>(), 0.5f));
            yield return new WaitForSeconds(.1f);
        }
    }
    IEnumerator TransitionOut(int selected)
    {
        StartCoroutine(Functions.FadeOut(scrollbarHandle, 0.5f));
        StartCoroutine(Functions.FadeOut(scrollbarSlider, 0.5f));

        for (int i = 1; i < characterButtons.Count; i++)
        {
            int above = selected - i;
            int below = selected + i;
            if (above >= 0)
            {
                StartCoroutine(Functions.FadeOut(characterButtons[above].GetComponentInChildren<Image>(), 0.2f));
            }
            if (below < characterButtons.Count)
            {
                StartCoroutine(Functions.FadeOut(characterButtons[below].GetComponentInChildren<Image>(), 0.2f));
            }
            if (above < 0 && below >= characterButtons.Count) {
                break;
            }
            yield return new WaitForSeconds(.1f);
        }
        StartCoroutine(Functions.FadeOut(characterButtons[selected].GetComponentInChildren<Image>(),0.2f));
        yield return new WaitForSeconds(.2f);
        SceneManager.LoadScene("screen_character");
    }

    public void Select(int selected)
    {
        StartCoroutine(TransitionOut(selected));
    }
}
