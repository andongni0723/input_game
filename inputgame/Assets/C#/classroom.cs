using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class classroom : MonoBehaviour
{
    public int classname;
    [SerializeField]
    bool istry; 
    InputField targetIF;

    public List<InputField> t11_LI = new List<InputField>();
    public List<InputField> t12_LI = new List<InputField>();
    public List<GameObject> cantryon_LI = new List<GameObject>();
    public List<GameObject> trueORflase_LI = new List<GameObject>();
    public List<GameObject> inputbutton_LI = new List<GameObject>();
    private void Update()
    {
        for (int i = 0; i < cantryon_LI.Count; i++)
        {
            if(cantryon_LI[i].activeSelf == true)
            {
                istry = true;
                //inputsetactive(0);
                break;
            }
            //inputsetactive(1);
            istry = false;
        }
    }
    public void inputword(string word)
    {
        if (istry)
        {
            findtarget();
            
            targetIF.text += word;
        }
    }

    public void inputsetactive(int index)
    {
        for (int i = 0; i < inputbutton_LI.Count; i++)
        {
            if(index == 0)
            {
                inputbutton_LI[i].GetComponent<Button>().interactable = true;
            }
            else
            {
                inputbutton_LI[i].GetComponent<Button>().interactable = false;
            }
        }
    }

    public void findtarget()
    {
        switch (classname)
        {
            case 11:
                for (int i = 0; i < t11_LI.Count; i++)
                {
                    if (t11_LI[i].text.Length == 0)
                    {
                        targetIF = t11_LI[i];
                        break;
                    }
                }
                break;
        }
    }

    public void trytrueORflase(int index)
    {
        switch (index)
        {
            case 111:
                
                if(t11_LI[0].text == "一" && t11_LI[1].text == "一" && t11_LI[2].text == "一")
                {
                    trueORflase_LI[0].SetActive(true);
                    trueORflase_LI[1].SetActive(false);
                }
                else
                {
                    trueORflase_LI[0].SetActive(false);
                    trueORflase_LI[1].SetActive(true);
                }
                break;

            case 112:

                if (t11_LI[3].text == "一" && t11_LI[4].text == "一")
                {
                    trueORflase_LI[2].SetActive(true);
                    trueORflase_LI[3].SetActive(false);
                }
                else
                {
                    trueORflase_LI[2].SetActive(false);
                    trueORflase_LI[3].SetActive(true);
                }
                break;

            case 113:

                if (t11_LI[5].text == "一" && t11_LI[6].text == "丨")
                {
                    trueORflase_LI[4].SetActive(true);
                    trueORflase_LI[5].SetActive(false);
                }
                else
                {
                    trueORflase_LI[4].SetActive(false);
                    trueORflase_LI[5].SetActive(true);
                }
                break;

            case 114:

                if (t11_LI[7].text == "一" && t11_LI[8].text == "丨" && t11_LI[9].text == "一" )
                {
                    trueORflase_LI[6].SetActive(true);
                    trueORflase_LI[7].SetActive(false);
                }
                else
                {
                    trueORflase_LI[6].SetActive(false);
                    trueORflase_LI[7].SetActive(true);
                }
                break;

            case 115:

                if (t11_LI[10].text == "丿" && t11_LI[11].text == "一" && t11_LI[12].text == "丨" && t11_LI[13].text == "一" && t11_LI[14].text == "丿")
                {
                    trueORflase_LI[8].SetActive(true);
                    trueORflase_LI[9].SetActive(false);
                }
                else
                {
                    trueORflase_LI[8].SetActive(false);
                    trueORflase_LI[9].SetActive(true);
                }
                break;

            case 116:

                if (t11_LI[15].text == "丿" && t11_LI[16].text == "一" && t11_LI[17].text == "一" && t11_LI[18].text == "丿"&& t11_LI[19].text == "、")
                {
                    trueORflase_LI[10].SetActive(true);
                    trueORflase_LI[11].SetActive(false);
                }
                else
                {
                    trueORflase_LI[10].SetActive(false);
                    trueORflase_LI[11].SetActive(true);
                }
                break;
            case 117:

                if (t11_LI[24].text == "、" && t11_LI[21].text == "一"  && t11_LI[22].text == "フ" && t11_LI[23].text == "フ" && t11_LI[20].text == "、")
                {
                    trueORflase_LI[12].SetActive(true);
                    trueORflase_LI[13].SetActive(false);
                }
                else
                {
                    trueORflase_LI[12].SetActive(false);
                    trueORflase_LI[13].SetActive(true);
                }
                break;
        }
    }

    public void error(GameObject parent)
    {
        //find gameobject of tag"IF"
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            if(parent.transform.GetChild(i).tag == "IF")
            {
                parent.transform.GetChild(i).GetComponent<InputField>().text = "";
            }
        }
    }
}
