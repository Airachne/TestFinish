using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GroupImageColor : MonoBehaviour
{
    void Start()
    {
        ChangeColorImage();
    }

    public void ChangeColorImage()
    {
        for (int i = 0; i < transform.childCount; i++) 
        {
            ImageColor thisItem = transform.GetChild(i).GetComponent<ImageColor>(); 
            thisItem.gameObject.GetComponent<Image>().color = new Color(Random.value, Random.value, Random.value);
        }    
    }
}
