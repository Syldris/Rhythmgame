using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[SerializeField]
public class SelectManager : MonoBehaviour
{
    public List<GameObject> Songlist;

    [SerializeField]private int order;

    [SerializeField]private int difficulty;

    [SerializeField] private Text difficulty_Text;

    [SerializeField] private AudioSource SemyeongSong;

    [SerializeField] private AudioSource NyanCat;

    [SerializeField] private AudioSource BrainPower;

    [SerializeField] private AudioSource QueenAluett;

    [SerializeField] private AudioSource FreedomDive;

    [SerializeField] private GameObject Canvas;

    [SerializeField] private GameObject CheatOn;

    [SerializeField] private GameObject Cheatoff;

    [SerializeField] private Text NoteSpeedText;

    [SerializeField] private Text offsetText;

    [SerializeField] private Text SemyeongSong_Score;

    [SerializeField] private Text NyanCat_Score;

    [SerializeField] private Text BrainPower_Score;

    [SerializeField] private Text QueenAluett_Score;

    [SerializeField] private Text FreedomDive_Score;

    public Slider BGM_slider;
    public Slider SE_slider;
    public float BGM;
    public float SE;

    public void Start()
    {
        OpenSong();
        Song_play();
        Setting_Start();
        MaxScore();
        if (ManagerMent.instance.Cheat)
        {
            Cheatoff.SetActive(false);
            CheatOn.SetActive(true);
        }
        else
        {
            CheatOn.SetActive(false);
            Cheatoff.SetActive(true);
        }
    }


    public void MaxScore()
    {
        SemyeongSong_Score.text = ManagerMent.instance.SemyeongSongScore.ToString();
        NyanCat_Score.text = ManagerMent.instance.NyanCatScore.ToString();
        BrainPower_Score.text = ManagerMent.instance.BrainPowerScore.ToString();
        QueenAluett_Score.text = ManagerMent.instance.QueenAluettScore.ToString();
        FreedomDive_Score.text = ManagerMent.instance.FreedomDiveScore.ToString();
    }

    public void Max_Score()
    {
        SemyeongSong_Score.text = ManagerMent.instance.SemyeongSongScore.ToString();
        NyanCat_Score.text = ManagerMent.instance.NyanCatScore.ToString();
        BrainPower_Score.text = ManagerMent.instance.BrainPowerScore.ToString();
        QueenAluett_Score.text = ManagerMent.instance.QueenAluettScore.ToString();
        FreedomDive_Score.text = ManagerMent.instance.FreedomDiveScore.ToString();
    }

    public void Setting_Start()
    {
        BGM_slider.value = ManagerMent.instance.BGM;
        SE_slider.value = ManagerMent.instance.SE;
        NoteSpeedText.text = ManagerMent.instance.Note_Speed.ToString("F1");
        offsetText.text = ManagerMent.instance.offset.ToString("F1");
    }

    public void NoteSpeed_plus()
    {
        ManagerMent.instance.Note_Speed += 0.1f;
        if(ManagerMent.instance.Note_Speed > 20.0f)
        {
            ManagerMent.instance.Note_Speed = 20.0f;
        }
        NoteSpeedText.text = ManagerMent.instance.Note_Speed.ToString("F1");
    }
    public void NoteSpeed_plus_plus()
    {
        ManagerMent.instance.Note_Speed += 1.0f;
        if (ManagerMent.instance.Note_Speed > 20.0f)
        {
            ManagerMent.instance.Note_Speed = 20.0f;
        }
        NoteSpeedText.text = ManagerMent.instance.Note_Speed.ToString("F1");
    }
    public void NoteSpeed_minus()
    {
        ManagerMent.instance.Note_Speed -= 0.1f;
        if (ManagerMent.instance.Note_Speed < 5.0f)
        {
            ManagerMent.instance.Note_Speed = 5.0f;
        }
        NoteSpeedText.text = ManagerMent.instance.Note_Speed.ToString("F1");
    }
    public void NoteSpeed_minus_minus()
    {
        ManagerMent.instance.Note_Speed -= 1.0f;
        if (ManagerMent.instance.Note_Speed < 5.0f)
        {
            ManagerMent.instance.Note_Speed = 5.0f;
        }
        NoteSpeedText.text = ManagerMent.instance.Note_Speed.ToString("F1");
    }
    public void offset_plus()
    {
        ManagerMent.instance.offset += 0.1f;
        if (ManagerMent.instance.offset > 1.0f)
        {
            ManagerMent.instance.offset = 1.0f;
        }
        offsetText.text = ManagerMent.instance.offset.ToString("F1");
    }
    public void offset_plus_plus()
    {
        ManagerMent.instance.offset += 0.5f;
        if (ManagerMent.instance.offset > 1.0f)
        {
            ManagerMent.instance.offset = 1.0f;
        }
        offsetText.text = ManagerMent.instance.offset.ToString("F1");
    }
    public void offset_minus()
    {
        ManagerMent.instance.offset -= 0.1f;
        if (ManagerMent.instance.offset < -1.0f)
        {
            ManagerMent.instance.offset = -1.0f;
        }
        offsetText.text = ManagerMent.instance.offset.ToString("F1");
    }
    public void offset_minus_minus()
    {
        ManagerMent.instance.offset -= 0.5f;
        if (ManagerMent.instance.offset < -1.0f)
        {
            ManagerMent.instance.offset = -1.0f;
        }
        offsetText.text = ManagerMent.instance.offset.ToString("F1");
    }
    public void Update()
    {
        BGM = BGM_slider.value;
        SE = SE_slider.value;
        ManagerMent.instance.order = order;
        ManagerMent.instance.BGM = BGM;
        ManagerMent.instance.SE = SE;

        SemyeongSong.volume = 0.6f * ManagerMent.instance.BGM * 2;
        NyanCat.volume = 0.5f * ManagerMent.instance.BGM * 2;
        BrainPower.volume = 0.2f * ManagerMent.instance.BGM * 2;
        QueenAluett.volume = 0.3f * ManagerMent.instance.BGM * 2;
        FreedomDive.volume = 0.3f * ManagerMent.instance.BGM * 2;
    }

    public void LeftArrowButton()
    {
        if (order > 0)
        {
            Songlist[order].SetActive(false);
            order -= 1;
            OpenSong();
            Song_difficulty();
            Song_play();
        }
        else
        {
            Songlist[order].SetActive(false);
            order = Songlist.Count - 1;
            OpenSong();
            Song_difficulty();
            Song_play();
        }
    }
    public void RightArrowButton()
    {
        if(order < Songlist.Count - 1)
        {
            Songlist[order].SetActive(false);
            order += 1;
            OpenSong();
            Song_difficulty();
            Song_play();
        }
        else
        {
            Songlist[order].SetActive(false);
            order = 0;
            OpenSong();
            Song_difficulty();
            Song_play();
        }
    }

    public void Out_game()
    {
        SceneManager.LoadScene("Intro_Scene");
    }

    public void OpenSong()
    {
        Songlist[order].SetActive(true);
    }

    public void Song_difficulty()
    {
        switch (order)
        {
            case 0:
                difficulty = 2;
                difficulty_Text.color = new Color32(194,255,61,255);
                break;
            case 1:
                difficulty = 5;
                difficulty_Text.color = new Color32(76, 116, 255, 255);
                break;
            case 2:
                difficulty = 7;
                difficulty_Text.color = new Color32(255, 214, 54, 255);
                break;
            case 3:
                difficulty = 16;
                difficulty_Text.color = new Color32(255, 119, 47, 255);
                break;
            case 4:
                difficulty = 20;
                difficulty_Text.color = new Color32(243, 49, 64, 255);
                break;
        }    
        difficulty_Text.text = difficulty.ToString();
    }

    public void Song_play()
    {
        switch (order)
        {
            case 0:
                FreedomDive.Stop();
                NyanCat.Stop();
                SemyeongSong.time = 10.3f;
                SemyeongSong.Play();
                break;
            case 1:
                SemyeongSong.Stop();
                BrainPower.Stop();
                NyanCat.time = 0;
                NyanCat.Play();
                break;
            case 2:
                NyanCat.Stop();
                QueenAluett.Stop();
                BrainPower.time = 103.7f;
                BrainPower.Play();
                break;
            case 3:
                BrainPower.Stop();
                FreedomDive.Stop();
                QueenAluett.time = 70.8f;
                QueenAluett.Play();
                break;
            case 4:
                QueenAluett.Stop();
                SemyeongSong.Stop();
                FreedomDive.time = 47.3f;
                FreedomDive.Play();
                break;
        }
    }


    public void Song_Start()
    {
        ManagerMent.instance.GameStart(order);
    }

    public void Setting_On()
    {
        Canvas.gameObject.SetActive(true);
    }

    public void Setting_Off()
    {
        Canvas.SetActive(false);
    }

    public void CheatKey()
    {
        ManagerMent.instance.Cheat = !ManagerMent.instance.Cheat;
        if(ManagerMent.instance.Cheat)
        {
            Cheatoff.SetActive(false);
            CheatOn.SetActive(true);
        }
        else
        {
            CheatOn.SetActive(false);
            Cheatoff.SetActive(true);
        }    
    }    

}
