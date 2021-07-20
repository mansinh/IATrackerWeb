using System.Collections;
using System.Collections.Generic;

public class Character 
{
    int damage;
    int strain;

    public int AddDamage() {
        damage++;
        return damage;  
    }

    public int AddStrain()
    {
        strain++;
        return strain;
    }
}
