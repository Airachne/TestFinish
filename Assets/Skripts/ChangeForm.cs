using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeForm : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    public GameObject[] myPrefab;
    public GameObject[] myPrefabLogo;

    [SerializeField] Transform parent;
    [SerializeField]int count;
    [SerializeField] bool delete;
    [SerializeField] bool create;

    void Start()
    {
        GameObject formName = Instantiate(myPrefab[count], new Vector2(parent.position.x, parent.position.y), Quaternion.identity, parent);
        formName.name = "Form";
        ChangeForms();
        delete = false;
        create = false;
    }

    void Update()
    {
        MoveForm();
        if (delete == false && ColorSetings.pageCoun == 2)
        {
            GameObject.Find("Form").transform.position = Vector2.Lerp(GameObject.Find("Form").transform.position, GameObject.Find("DeletePos").transform.position, speed * Time.deltaTime);
                //transform.position = Vector2.Lerp(GameObject.Find("Image").transform.position, GameObject.Find("DeletePos").transform.position, speed * Time.deltaTime);
        }
        if (create == true)
        {
            GameObject.Find("Logo").transform.position = Vector3.Lerp(GameObject.Find("Logo").transform.position, parent.transform.position, speed * Time.deltaTime);
            GameObject.Find("Form1").transform.position = Vector3.Lerp(GameObject.Find("Form1").transform.position, parent.transform.position, speed * Time.deltaTime);
        }
    }

    public void ChangeForms()
    { 
        if (ColorSetings.pageCoun == 1)
        {
            count++;
            if (count >= myPrefab.Length)
            {
                count = myPrefab.Length - 1;
            }
            else if (count <= 0)
            {
                count = 0;
            }

            Destroy(GameObject.Find("Form"));

            //   Instantiate(myPrefab[count], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity, parent);
            GameObject formName = Instantiate(myPrefab[count], new Vector2(parent.position.x, parent.position.y), Quaternion.identity, parent);
            formName.name = "Form";
        }
    }
    public void ChangeFormsOld()
    {
        if (ColorSetings.pageCoun == 1)
        {
            count--;
            if (count >= myPrefab.Length)
            {
                count = myPrefab.Length - 1;
            }
            else if (count <= 0)
            {
                count = 0;
            }
            Destroy(GameObject.Find("Form"));

            //   Instantiate(myPrefab[count], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity, parent);
            GameObject formName = Instantiate(myPrefab[count], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity, parent);
            formName.name = "Form";
        }
    }
    public void MoveForm()
    {
        if (ColorSetings.pageCoun == 2)
        {
            if (delete == false)
            {
                if (GameObject.Find("Form").transform.position.x <= GameObject.Find("DeletePos").transform.position.x+30)
                {
                    Destroy(GameObject.Find("Form"));
                    delete = true;
                }
            }
          
            if (create == false)
            {
                GameObject.Find("Image").gameObject.SetActive(false);

                //Instantiate(myPrefab[count], new Vector2(GameObject.Find("CreatePos").transform.position.x, GameObject.Find("CreatePos").transform.position.y), Quaternion.identity, parent);
                GameObject formName = Instantiate(myPrefab[count], new Vector2(GameObject.Find("CreatePos").transform.position.x, GameObject.Find("CreatePos").transform.position.y), Quaternion.identity, parent);
                formName.name = "Form1";

                GameObject logoName = Instantiate(myPrefabLogo[count], new Vector2(GameObject.Find("CreatePos").transform.position.x, GameObject.Find("CreatePos").transform.position.y), Quaternion.identity, parent);
                logoName.name = "Logo";
                create = true;
            }
        }
    }
    public void ChangeFormsLogo()
    {
        if (ColorSetings.pageCoun == 2)
        {
            count++;
            if (count >= myPrefabLogo.Length)
            {
                count = myPrefabLogo.Length - 1;
            }
            else if (count <= 0)
            {
                count = 0;
            }

            Destroy(GameObject.Find("Logo"));
            //   Instantiate(myPrefab[count], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity, parent);
            GameObject logoName = Instantiate(myPrefabLogo[count], new Vector2(parent.position.x, parent.position.y), Quaternion.identity, parent);
            logoName.name = "Logo";
        }
    }
    public void ChangeFormsOldLogo()
    {
        if (ColorSetings.pageCoun == 2)
        {
            count--;
            if (count >= myPrefabLogo.Length)
            {
                count = myPrefabLogo.Length - 1;
            }
            else if (count <= 0)
            {
                count = 0;
            }
            Destroy(GameObject.Find("Logo"));
            //   Instantiate(myPrefab[count], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity, parent);
            GameObject logoName = Instantiate(myPrefabLogo[count], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity, parent);
            logoName.name = "Logo";
        }
    }
}

