using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
[SerializeField]
public class Scoremanager : MonoSigleton<Scoremanager>
{
    [SerializeField] private GameObject Canvas;

    [SerializeField] private List<GameObject> Image_List;

    [SerializeField] private int Score;

    [SerializeField] private int Perfect;

    [SerializeField] private int Great;

    [SerializeField] private int Good;

    [SerializeField] private int Bad;

    [SerializeField] private int Miss;

    [SerializeField] private Text ScoreText;

    [SerializeField] private Text ScoreText_2;

    [SerializeField] private Text PerfectText;

    [SerializeField] private Text PerfectText_2;

    [SerializeField] private Text GreatText;

    [SerializeField] private Text GoodText;

    [SerializeField] private Text BadText;

    [SerializeField] private Text MissText;

    [SerializeField] private GameObject ScoreButton;

    [SerializeField] private GameObject Score_ON_Text;

    public void Img_Loading(int order)
    {
        Canvas.SetActive(true);
        ScoreText.text = Score.ToString();
        ScoreText_2.text = Score.ToString();
        PerfectText.text = Perfect.ToString();
        PerfectText_2.text = Perfect.ToString();
        GreatText.text = Great.ToString();
        GoodText.text = Good.ToString();
        BadText.text = Bad.ToString();
        MissText.text = Miss.ToString();
        Image_List[order].SetActive(true);
    }

    public void Score_button()
    {
        switch (ManagerMent.instance.order)
        {
            case 0:
                if(Score > ManagerMent.instance.SemyeongSongScore)
                {
                    ManagerMent.instance.SemyeongSongScore = Score;
                }
                break;
            case 1:
                if (Score > ManagerMent.instance.NyanCatScore)
                {
                    ManagerMent.instance.NyanCatScore = Score;
                }
                break;
            case 2:
                if (Score > ManagerMent.instance.BrainPowerScore)
                {
                    ManagerMent.instance.BrainPowerScore = Score;
                }
                break;
            case 3:
                if (Score > ManagerMent.instance.QueenAluettScore)
                {
                    ManagerMent.instance.QueenAluettScore = Score;
                }
                break;
            case 4:
                if (Score > ManagerMent.instance.FreedomDiveScore)
                {
                    ManagerMent.instance.FreedomDiveScore = Score;
                }
                break;
        }
        ScoreButton.SetActive(false);
        Score_ON_Text.SetActive(true);
    }

    public void Update()
    {
        Score = Gamemanager.Instance.Score;
    }

    public void Perfect_plus()
    {
        Perfect += 1;
    }

    public void Great_plus()
    {
        Great += 1;
    }

    public void Good_plus()
    {
        Good += 1;
    }

    public void Bad_plus()
    {
        Bad += 1;
    }

    public void Miss_plus()
    {
        Miss += 1;
    }
}
