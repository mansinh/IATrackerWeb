using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Functions
{
    public static Sprite[] GetSprites(string path)
    {
        object[] files = Resources.LoadAll(path, typeof(Sprite));
        Sprite[] sprites = new Sprite[files.Length];
        files.CopyTo(sprites, 0);
        return sprites;
    }

}
