using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using UnityEngine.UI;

//[XmlRoot("Sound")]
[XmlRoot]
public class XMLSettings : MonoBehaviour
{
    //  [XmlAnyElement("audioSettings")]  //, XmlArrayItem("Sound")
    //   public bool audioSettings;
    //    public List<string> toogleName;
    /* [XmlArray("usersNames"), XmlArrayItem("name")]
     public  List<Toggle> toogle;
     [XmlArray("usersNames1"), XmlArrayItem("name1")]
     public  List<Toggle> toogleLogo;
    // public  GameObject myPrefab;
  //   public  Transform parent;
     [XmlArray("usersNames2"), XmlArrayItem("name2")]
     public  List<Image> forms;
     [XmlArray("usersNames3"), XmlArrayItem("name3")]
     public  List<Image> logos;*/
    // public  int pageCoun;
  //  [XmlArray("usersNames1"), XmlArrayItem("name1")]
    public List<Toggle> toogleLogo;
    public int pageCoun;

}
