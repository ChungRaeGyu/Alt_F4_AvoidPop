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
        
        myColor=transform.parent.name == 
        "Player1(Clone)" ? (color)DataManager.instance.characterNum : (color)DataManager.instance.characterNum2;
        
        SetColor(myColor);

    }
    public void SetColor(color num){
        switch (num)
        {
            case color.Red: spriteRenderer.color = Color.red; break;
            case color.Blue: spriteRenderer.color = Color.blue; break;
            case color.Green: spriteRenderer.color = Color.green; break;
            case color.Yellow: spriteRenderer.color = Color.yellow; break;
        }
    }
}
