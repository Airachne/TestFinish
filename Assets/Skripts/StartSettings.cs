using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSettings : MonoBehaviour
{      List<string> nameText = new List<string> {"Выберите форму","Выберите лого","Название команды"};
    [SerializeField] GameObject page3;

    void Start()
    {
        ColorSetings.pageCoun = 1;
        page3.gameObject.SetActive(false);
    }
  
    public void NextPage()
    {
        if (ColorSetings.pageCoun < 3)
        {
            ColorSetings.pageCoun++;
            GameObject.Find("NamePage").GetComponent<Text>().text = nameText[ColorSetings.pageCoun - 1];
            if (ColorSetings.pageCoun > 2)
            {
                page3.gameObject.SetActive(true);
                TableForm();
                GameObject.Find("TEST").gameObject.SetActive(false);
                GameObject.Find("Scene1/2_Back").gameObject.SetActive(false);
            }
        }
        else Application.Quit();
    }

    public void TableForm()
    {
        GameObject.Find("Form1").gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        GameObject.Find("Logo").gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        GameObject.Find("Form1").transform.SetParent(GameObject.Find("PAPQ").transform);
        GameObject.Find("Logo").transform.SetParent(GameObject.Find("PAPQ").transform);

        GameObject.Find("Form1").gameObject.transform.position = GameObject.Find("FormDemo").gameObject.transform.position;
        GameObject.Find("Logo").gameObject.transform.position = GameObject.Find("LogoDemo").gameObject.transform.position;
    }
    public void Search(InputField field) // функция поиска по имени в поисковой строке
    {
        if (field.text.Length > 10) // если строка не пустая
        {
            field.GetComponentInChildren<Text>().color = Color.red;

             GameObject.Find("ButtonNextPage").GetComponent<Button>().interactable =false;
             GameObject.Find("ButtonNextPage").GetComponent<Image>().color = new Color(255f, 0f, 0f, .5f);
        }
        else
        {
            field.GetComponentInChildren<Text>().color = Color.white;
            GameObject.Find("ButtonNextPage").GetComponent<Button>().interactable = true;
            GameObject.Find("ButtonNextPage").GetComponent<Image>().color = Color.white;
        }
    }
}
