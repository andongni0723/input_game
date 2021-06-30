using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class teachpanel : MonoBehaviour
{
    public List<GameObject> BigClass_LI = new List<GameObject>();
    public List<GameObject> SmallClass_LI = new List<GameObject>();

    public GameObject smallClass;

    public GameObject manager;
   
    public void onoptionclick(GameObject option)
    {
        smallClass.transform.SetAsLastSibling();
        var position = option.transform.GetSiblingIndex();
        smallClass.transform.SetSiblingIndex(position + 1);

        SmallClass_LI[position].GetComponent<Toggle>().isOn = true;
    }

    public void changescene()
    {
        if (manager.activeSelf == true)
            SceneManager.LoadScene("start");
        else
            SceneManager.LoadScene("teach");
    }
}
