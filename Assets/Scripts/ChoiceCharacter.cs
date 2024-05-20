using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceCharacter : MonoBehaviour
{
    public Sprite[] character;
    public Image chooseCharacter;

    public void ChooseChracter(int num)
    {
        chooseCharacter.sprite = character[num];
        DataManager.instance.characterNum = num;
    }
}
