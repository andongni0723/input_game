using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changepage : MonoBehaviour
{
    [SerializeField]
    int page = 1;
    [Header("клеє")]
    public InputField page_IF;

    public List<GameObject> page_L = new List<GameObject>();

    private void Update()
    {
        
    }

    public void pageactive()
    {
        page_L[page].GetComponent<Toggle>().isOn = true;
        page_IF.text = page.ToString();
    }

    public void rightbutton()
    {
        if(page != 9)
            page++;
        pageactive();
    }
    public void leftbutton()
    {
        if(page != 0)
            page--;
        pageactive();
    }

    public void inputpage()
    {
        if (int.Parse(page_IF.text) < 0)
            page_IF.text = "0";
        else if (int.Parse(page_IF.text) > 9)
            page_IF.text = "9";
        page = int.Parse(page_IF.text);
        pageactive();
    }

    public void back()
    {
        SceneManager.LoadScene("start");
    }

    public void gotopage(int lpage)
    {
        page = lpage;
        pageactive();
    }
}
