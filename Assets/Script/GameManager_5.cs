using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class GameManager_5 : MonoBehaviour
{
    public InputField inputName;

    public Text scoreListTxt;
    public Text nameListTxt;

    public List<int> scoreList = new List<int>();
    public List<String> nameList = new List<String>();

    // Start is called before the first frame update
    void Start()
    {
        PreRankingTxt();
        inputName.characterLimit = 12;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            EnterBtnClick();
        }
    }

    public void EnterBtnClick()
    {
        Save();
        SceneManager.LoadScene("6_Ranking");
    }

    public void Save()
    {
        if (inputName.text == "")
        {
            PlayerPrefs.SetString(GameManager_4.nowRank.ToString() + "BestName", "POTATO");
        }
        else
        {
            PlayerPrefs.SetString(GameManager_4.nowRank.ToString() + "BestName", inputName.text);
        }

    }

    public void PreRankingTxt()
    {
        //��ŷ ��������
        for (int i = 0; i < 10; i++)
        {
            scoreList.Insert(i, PlayerPrefs.GetInt(i + "BestScore"));
            nameList.Insert(i, PlayerPrefs.GetString(i.ToString() + "BestName"));
        }

        scoreListTxt.text = $"{scoreList[0]}\n" +
                            $"{scoreList[1]}\n" +
                            $"{scoreList[2]}\n" +
                            $"{scoreList[3]}\n" +
                            $"{scoreList[4]}\n" +
                            $"{scoreList[5]}\n" +
                            $"{scoreList[6]}\n" +
                            $"{scoreList[7]}\n" +
                            $"{scoreList[8]}\n" +
                            $"{scoreList[9]}\n";
        nameListTxt.text = $"{nameList[0]}\n" +
                           $"{nameList[1]}\n" +
                           $"{nameList[2]}\n" +
                           $"{nameList[3]}\n" +
                           $"{nameList[4]}\n" +
                           $"{nameList[5]}\n" +
                           $"{nameList[6]}\n" +
                           $"{nameList[7]}\n" +
                           $"{nameList[8]}\n" +
                           $"{nameList[9]}\n";
    }
}
