using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    public enum color{
        Red,
        Blue,
        Green,
        Yellow,
    }
    SpriteRenderer spriteRenderer;
    color myColor;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void SetColor(int num){
        switch (num)
        {
            case (int)color.Red: spriteRenderer.color = Color.red; break;
            case (int)color.Blue: spriteRenderer.color = Color.blue; break;
            case (int)color.Green: spriteRenderer.color = Color.green; break;
            case (int)color.Yellow: spriteRenderer.color = Color.yellow; break;
        }
    }
}
