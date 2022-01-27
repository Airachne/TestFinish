using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EditColor : MonoBehaviour
{
    XMLSettings colorXml = XMLOp.Deserialize<XMLSettings>("Assets/XMLColorSetings/colorSetings.xml");

    public List<Toggle> toogle;
    public List<Toggle> toogleLogo;

    [SerializeField] bool count;

    void Start()
    {
        for (int i = 0; i < transform.childCount; i++) 
        {
            Toggle thisItem = transform.GetChild(i).GetComponent<Toggle>(); 
            toogle.Add(thisItem);
            toogleLogo.Add(thisItem);
        }
        ColorSetings.toogle = toogle;
        ColorSetings.toogleLogo = toogleLogo;
    }
    public void ChangeColor()
    {
        if (ColorSetings.pageCoun == 1)
        {
            FormColor formColor = FindObjectOfType(typeof(FormColor)) as FormColor;
          
            count = false;
            for (int i = 0; i < toogle.Count; i++)
            {
                if (toogle[i].image.color == EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color)
                {
                    count = true;
                }
            }

            if (count == false)
            {
                for (int i = 0; i < toogle.Count; i++)
                {
                    if (toogle[i].isOn == true)
                    {
                        toogle[i].image.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;

                        formColor.forms[i + 1].color = toogle[i].image.color;
                    }
                }
            }
        }
    }
    public void ChangeColorLogo()
    {
        if (ColorSetings.pageCoun == 2)
        {
            LogoColor formColorLogo = FindObjectOfType(typeof(LogoColor)) as LogoColor;
       
            count = false;
            for (int i = 0; i < toogleLogo.Count; i++)
            {
                if (toogleLogo[i].image.color == EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color)
                {
                    count = true;
                }
            }

            if (count == false)
            {
                for (int i = 0; i < toogleLogo.Count; i++)
                {
                    if (toogleLogo[i].isOn == true)
                    {
                       toogleLogo[i].image.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;

                        formColorLogo.logos[i + 1].color = toogleLogo[i].image.color;
                    }
                }
            }
        }
    }
}

// https://github.com/Airachne/Test4
// https://forum.orkons.ru/topic/332-unity-metody-dostupa-k-skriptam-i-obektam/