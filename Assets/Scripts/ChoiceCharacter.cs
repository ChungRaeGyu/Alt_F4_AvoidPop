using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceCharacter : MonoBehaviour
{
    public Sprite[] character;
    public Image chooseCharacter;

    public Sprite[] character2;
    public Image chooseCharacter2;

    public void ChooseChracter(int num)
    {
        chooseCharacter.sprite = character[num];
        DataManager.instance.characterNum = num;
    }

    public void ChooseCharacter2P(int num2)
    {
        chooseCharacter2.sprite = character2[num2];
        DataManager.instance.characterNum2 = num2;
    }
}
