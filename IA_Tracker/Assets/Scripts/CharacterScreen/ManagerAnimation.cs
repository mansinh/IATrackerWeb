using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerAnimation : MonoBehaviour
{
    [SerializeField] Animator[] damageAnimator;
    [SerializeField] Image characterImage;

    int currentDamageAnim = 0;
    public void Init(Character character)
    {
        
    }

    public void OnDamage() {
        float damageType = Random.value;
        if (damageType < 0.3)
        {
            damageAnimator[currentDamageAnim].SetTrigger("Blast");
        }
        else if (damageType < 0.6)
        {
            damageAnimator[currentDamageAnim].SetTrigger("Slice");
        }
        else 
        {
            damageAnimator[currentDamageAnim].SetTrigger("Impact");
        }
        
        currentDamageAnim++;
        if (currentDamageAnim >= damageAnimator.Length) {
            currentDamageAnim = 0;
        }
        characterImage.rectTransform.localPosition = Vector3.zero;
        StartCoroutine(Functions.Shake(characterImage.transform,0.3f,5,0.2f));
    }
}
