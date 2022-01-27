using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Xml.Serialization;

public class FormColor : MonoBehaviour
{
    XMLSettings sound = XMLOp.Deserialize<XMLSettings>("Assets/XMLColorSetings/colorSetings.xml");
    public List<Image> forms;

    void Start()
    {
        //EditColor editColor = FindObjectOfType(typeof(EditColor)) as EditColor;
        ChageFormColors();
    }

    public void ChageFormColors()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Image thisItem = transform.GetChild(i).GetComponent<Image>(); 
            if (i > 0 && i < 4)
            {
                thisItem.color = ColorSetings.toogle[i - 1].image.color;
                forms.Add(thisItem);
            }
            else
                forms.Add(thisItem);

        }
        ColorSetings.forms = forms;
        if (ColorSetings.pageCoun == 2)
        {
            this.gameObject.transform.localScale = new Vector3(2, 2, 2);
        }

    }
}
