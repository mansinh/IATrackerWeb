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
        Color c = image.color;

        // fade from opaque to transparent
        for (float i = c.a; i >= 0; i -= Time.deltaTime / duration)
        {
            c.a = i;
            image.color = c;
            yield return null;
        }
        c.a = 0;
        image.color = c;
        image.gameObject.SetActive(false);
    }
    public static IEnumerator FadeIn(Image image, float duration)
    {
        image.gameObject.SetActive(true);
        Color c = image.color;
        // fade from transparent to opaque
        for (float i = c.a; i <= 1; i += Time.deltaTime / duration)
        {
            c.a = i;
            image.color = c;
            yield return null;
        }
        c.a = 1;
        image.color = c;
    }

    public static IEnumerator SlideIn(Transform t, float duration, float offset)
    {
        Vector3 p = t.position;
        Vector3 end = new Vector3(p.x, p.y, p.z);
        Vector3 start = new Vector3(offset, p.y, p.z);


        for (float i = 0; i <= 1; i += Time.deltaTime / duration)
        {
            t.position = Vector3.Lerp(start, end, i);
            yield return null;
        }
        t.position = end;
    }
    public static IEnumerator Shake(Transform t, float duration, float offset, float delay)
    {
        Vector3 p = t.position;

        for (float i = 0; i <= 1; i += Time.deltaTime / delay)
        {
            yield return null;
        }

        for (float i = 0; i <= 1; i += Time.deltaTime / duration)
        {

            t.position = p + (Vector3)Random.insideUnitCircle*offset;
            yield return null;
        }
        t.position = p;
    }
}
