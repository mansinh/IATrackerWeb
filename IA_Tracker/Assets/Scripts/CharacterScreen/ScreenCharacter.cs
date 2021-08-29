using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCharacter : MonoBehaviour
{
    Character character;
    [SerializeField] Material transition;
    ManagerStatus statusManager;
    ManagerAnimation animationManager;
   

    // Start is called before the first frame update
    void Start()
    {
        character = new Character();
        statusManager = GetComponent<ManagerStatus>();
        statusManager.Init(character);
        animationManager = GetComponent<ManagerAnimation>();
        animationManager.Init(character);

        transition.SetFloat("_Boundary",0f);
        StartCoroutine(Transition());
    }


    public void OnAddDamage(CustomButton b) 
    {
        statusManager.AddDamage(b);
        animationManager.OnDamage();
    }

    public void OnMinusDamage(CustomButton b)
    {
        statusManager.MinusDamage(b);
    }














    IEnumerator Transition() 
    {
        for (float i = 0; i <= 1; i += Time.deltaTime / 2)
        {
            transition.SetFloat("_Boundary", i);
            yield return null;
        }
        transition.SetFloat("_Boundary", 1);
    }



   
}
