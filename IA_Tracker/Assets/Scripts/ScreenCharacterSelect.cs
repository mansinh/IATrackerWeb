using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenCharacterSelect : MonoBehaviour
{
    [SerializeField] Transform listLayout;
    [SerializeField] GameObject characterSelectButtonPrefab;
    
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
            characterSelectButton.GetComponent<Image>().sprite = characterButtonImages[i];
            
        }
    }

    
    public void Select(int characterIndex)
    {
        print(characterIndex);
        SceneManager.LoadScene("screen_character");
    }
}
