using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Listat : MonoBehaviour
{
    public int Ind = 0;
    public List<Sprite> Sprites = new List<Sprite>();
    public Image Square;

    public void OnClick()
    {
        if (Ind == Sprites.Count - 1) Ind = 0;
        else Ind++;
        Square.GetComponent<Image>().sprite = Sprites[Ind];
    }
}