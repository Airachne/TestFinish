using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemButton : MonoBehaviour
{
    private Text buttonText; // кнопки являющеся элементами списка объектов для поиска и сортировки
    public List<string> itemTypes =  new List<string>{ "Зелья", "Разное", "Арсенал" }; // случайные имена элементов списка
    [SerializeField] int typeIndex; // индекс

    // Start is called before the first frame update
    void Start() // генерация настроек элементов при старте
    { 
        typeIndex = Random.Range(0, itemTypes.Count); // задаётся случайное значение из списка имён
        buttonText = GetComponentInChildren<Text>(); // обращение к дочернему элементу текст
        buttonText.text = itemTypes[typeIndex]; // присваивание значения тексту по случайному значению из списка
        this.name = itemTypes[typeIndex]; // присваивание имени по случайному значению из списка
    }

}
