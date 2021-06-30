using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class raceerror : MonoBehaviour
{
    public InputField errorword_IF;
    public GameObject error;
    public GameObject manager;
    public GameObject errorGameObj;
    public Text errorText_T;

    public Scrollbar scrollbar;

    private void Start()
    {
        
    }
    public void openpanel() { 
    }
    public void CopyFunction1()
    {
        TextEditor text = new TextEditor();
        text.text = errorword_IF.text;
        text.OnFocus();
        text.Copy();
    }

    public void web()
    {
        Application.OpenURL("http://t9.tiger-workshop.com/");
    }

    public void createprefab() 
    {
        errorword_IF.text = "";

        for (int i = 0; i < race.instance.answererrorQuestion_LI.Count; i++)
        {
            //create prefab
            GameObject prefab = Instantiate(errorGameObj,transform.position,Quaternion.identity);

            errorText_T = prefab.transform.GetChild(1).GetComponent<Text>();

            errorText_T.text = race.instance.answererrorQuestion_LI[i] + "\r\n" + race.instance.answererror_LI[i];
            prefab.transform.parent = manager.transform;
            prefab.GetComponent<RectTransform>().position = new Vector3(prefab.transform.position.x, prefab.transform.position.y, 0);

            //set error word
            errorword_IF.text += race.instance.answererrorQuestion_LI[i];
        }

        setheight();
    }

    public void setheight()
    {
        manager.GetComponent<RectTransform>().sizeDelta = new Vector2(manager.GetComponent<RectTransform>().rect.width, 305f * manager.transform.childCount);
        manager.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
    }
}
