using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class XMLSerializer : MonoBehaviour
{
    XMLSettings colorSetings = new XMLSettings();

//ColorSetings colorSetings = new ColorSetings();
    public void OnApplicationQuit()
    {
        SaveSound();
    }

    public void SaveSound()
    {
        //  colorSetings.audioSettings = SounMute.soundMute;
        // colorSetings.toogleName = ObjectState.idObject;
        //   colorSetings.toogleName = ColorSetings.
        /*   colorSetings.toogle = ColorSetings.toogle;
           colorSetings.toogleLogo = ColorSetings.toogleLogo;
         //  colorSetings.myPrefab = ColorSetings.myPrefab;
         //  colorSetings.parent = ColorSetings.parent;
           colorSetings.forms = ColorSetings.forms;
           colorSetings.logos = ColorSetings.logos;
         //  colorSetings.pageCoun = ColorSetings.pageCoun;*/
          colorSetings.pageCoun = ColorSetings.pageCoun;
        colorSetings.toogleLogo = ColorSetings.toogleLogo;


        XMLOp.Serialize(colorSetings, "Assets/XMLColorSetings/colorSetings.xml");
    }

}
