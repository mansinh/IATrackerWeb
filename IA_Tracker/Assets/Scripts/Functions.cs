using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Functions
{
    public static Sprite[] GetSprites(string path)
    {
        object[] files = Resources.LoadAll(path, typeof(Sprite));
        Sprite[] sprites = new Sprite[files.Length];
        files.CopyTo(sprites, 0);
        return sprites;
    }

    public static IEnumerator FadeOut(Image image, float duration)
    {
        float initialAlpha = image.color.a;
        // fade from opaque to transparent
        for (float i = initialAlpha; i >= 0; i -= Time.deltaTime / duration)
        {
            image.color = new Color(1, 1, 1, i);
            yield return null;
        }
        image.color = new Color(1, 1, 1, 0);
    }
    public static IEnumerator FadeIn(Image image, float duration)
    {
        float initialAlpha = image.color.a;
        // fade from transparent to opaque
        for (float i = initialAlpha; i <= 1; i += Time.deltaTime / duration)
        {
            image.color = new Color(1, 1, 1, i);
            yield return null;
        }
        image.color = new Color(1, 1, 1, 1);
    }
}
