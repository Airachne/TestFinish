using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class InventoryDisplay : MonoBehaviour
{
    public void ShowOnly(string itemType) // функция фильтрации элементов по имени
    {
        for (int i = 0; i < transform.childCount; i++) // цикл по дочерним элементам компонента content
        {
            InventoryItemButton thisItem = transform.GetChild(i).GetComponent<InventoryItemButton>(); // получение доступа к компонентам
            thisItem.gameObject.SetActive(thisItem.name == itemType); // если имя компонента равно значению фильтра
        }
    }

    public void ShowAll()// функция просмотра всех элементов 
    {
        for (int i = 0; i < transform.childCount; i++) // цикл по дочерним элементам компонента content
        {
            transform.GetChild(i).gameObject.SetActive(true); // показать все элементы
        }
    }

    public void Search(InputField field) // функция поиска по имени в поисковой строке
    {
        if (field.text != "") // если строка не пустая
        {
            for (int i = 0; i < transform.childCount; i++)// цикл по дочерним элемента компонента content
            {
                InventoryItemButton thisItem = transform.GetChild(i).GetComponent<InventoryItemButton>();// получение доступа к компонентам
                Regex regex = new Regex($@"{field.text}(\w*)", RegexOptions.IgnoreCase); /* при вводе значения в строку поиска создаётся переменная регулярного выражения
                                                                                                                  * в котором все совпадающие значения соотвествуют любому алфавитно-цифровому символу
                                                                                                                  и заданным параметром игнорирования регистра*/

                MatchCollection matches = regex.Matches(thisItem.name);  // Метод matches  принимает строку, к которой надо применить регулярные выражения, и возвращает коллекцию найденных совпадений.

                if (matches.Count>0)  // если количество совпадения больше 0
                {
                    foreach (var match in matches) // цикл отображения элементов при совпадении с вводом
                    {
                        thisItem.gameObject.SetActive(true); // если введённое значение совпадает с именем элемента
                    }
                }
              else thisItem.gameObject.SetActive(false); // иначе скрыть элементы
            }
        }
        else ShowAll(); // иначе показать все элементы
    }
}
