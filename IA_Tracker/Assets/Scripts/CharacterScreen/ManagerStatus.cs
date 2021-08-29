using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerStatus : MonoBehaviour
{
    Character character;
    
    public void Init(Character character) {
        this.character = character;
    }

    public void AddDamage(CustomButton b)
    {
        character.damage++;
        if (b != null)
        {
            b.SetText("" + character.damage);
            b.ShowLinkedButton();
        }
        
    }
    public void MinusDamage(CustomButton b)
    {
        character.damage--;
        if (b != null)
        {
            b.SetText("" + character.damage);
            if (character.damage == 0)
            {
                b.HideLinkedButton();
            }
        }
    }
}
