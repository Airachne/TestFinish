using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LogoColor : MonoBehaviour
{
    public List<Image> logos;

    void Start()
    {
        ChageLogoColors();
    }

    public void ChageLogoColors()
    {
        for (int i = 0; i < transform.childCount; i++) 
        {
            Image thisItem = transform.GetChild(i).GetComponent<Image>(); 
            if (i > 0 && i < 4)
            {
                thisItem.color = ColorSetings.toogle[i - 1].image.color;
                logos.Add(thisItem);
            }
            else
                logos.Add(thisItem);
        }
        ColorSetings.logos = logos;
    }
}
