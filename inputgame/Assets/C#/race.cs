using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class race : MonoBehaviour
{
    public static race instance;
    [SerializeField]
    int difficulty;
    bool isStart;

    float timer;

    int questionnum;
    int correctscore;

    float score;

    public List<string> word_LI = new List<string>();
    List<string> question_LI = new List<string>();

    public List<string> answererrorQuestion_LI = new List<string>();
    public List<string> answererror_LI = new List<string>();


    [Header("клеє")]
    public Text question_T;
    public InputField answer_IF;
    public InputField timer_IF;
    public Text timer_T;
    public GameObject end;
    public GameObject game;
    public GameObject setting;
    public GameObject back;
    public Text score_T;
    public Text dotestnum_T;
    public Text correctnum_T;
    public Dropdown dropdown_D;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        //startrace();
    }

    private void Update()
    {
        if (isStart)
        {
            
            timer_T.text = (timer -= Time.deltaTime).ToString("00");

            if (int.Parse(timer_T.text) <= 0)
            {
                gameover();
                GetComponent<raceerror>().createprefab();
            }
                

        }
        else
        {
            if(timer_IF.text != "")
                timer = float.Parse(timer_IF.text);
        }
    }

    public void backbutton()
    {
        if (isStart)
            SceneManager.LoadScene("race");

        if (setting.activeSelf == true)
            SceneManager.LoadScene("start");

        if (GetComponent<raceerror>().error.activeSelf == true)
            GetComponent<raceerror>().error.SetActive(false);
        else if(end.activeSelf == true)
            SceneManager.LoadScene("race");
    }

    public void changevalue()
    {
        if (float.Parse(timer_IF.text) <= 10f)
            timer_IF.text = "10";
    }

    public void changedifficulty()
    {
        difficulty = dropdown_D.value;
    }

    public void startrace()
    { 
        for (int i = 0; i < word_LI[difficulty].Length; i++)
        {   
            question_LI.Add(word_LI[difficulty].Substring(i, 1));
        }

        isStart = true;
    }

    public void givequestion()
    {
        question_T.text = question_LI[Random.Range(0, question_LI.Count)];
        questionnum++;

        answer_IF.text = "";
    }

    public void enter()
    {
        if (answer_IF.text == question_T.text)
        {
            correctscore++;
        }    
        else
        {
            answererrorQuestion_LI.Add(question_T.text);
            answererror_LI.Add(answer_IF.text);
        } 
    }

    public void gameover()
    { 
        end.SetActive(true);
        game.SetActive(false);
        
        isStart = false;
        score = Mathf.Round(correctscore / (float.Parse(timer_IF.text) / 5) * 100);   

        if(score > 100)
            score = 100;

        score_T.text = score.ToString();

        dotestnum_T.text = questionnum.ToString();
        correctnum_T.text = correctscore.ToString();

        
    }
}
