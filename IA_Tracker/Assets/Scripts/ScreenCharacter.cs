using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCharacter : MonoBehaviour
{
    Character character;

    // Start is called before the first frame update
    void Start()
    {
        character = new Character();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onDamageButton()
    {
        print("damage");
        character.AddDamage();
    }

    public void onStrainButton()
    {
        print("strain");
        character.AddStrain();
    }

    public void onConditionButton()
    {
        print("condition");
    }
}
