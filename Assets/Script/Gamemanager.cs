using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[SerializeField]
public class Gamemanager : MonoSigleton<Gamemanager>
{
    [SerializeField] public float Note_Speed;
    [SerializeField] private List<GameObject> instantiateObjects;
    [SerializeField] private GameObject Note;
    [SerializeField] private GameObject SmallNote;
    [SerializeField] private Text Score_Text;
    [SerializeField] private int Player_HP;
    [SerializeField] private Image HP_image;
    public List<judgement_line> judgement_lines;
    public List<Cheat_line> Cheat_lines;
    public List<bool> KeyDowncheck;
    public bool Text_instantiate;
    public bool Judgement_instantiate;
    public int Combo;
    public int Score;
    public GameObject SemyeongSong;
    public GameObject NyanCat;
    public GameObject BrainPower;
    public GameObject QueenAluett;
    public GameObject FreedomDive;
    public AudioSource hit;
    public AudioSource smallhit;


    private void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            KeyDowncheck[0] = true;
        }
        else
        {
            KeyDowncheck[0] = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            KeyDowncheck[1] = true;
        }
        else
        {
            KeyDowncheck[1] = false;
        }
        if (Input.GetKey(KeyCode.F))
        {
            KeyDowncheck[2] = true;
        }
        else
        {
            KeyDowncheck[2] = false;
        }
        if (Input.GetKey(KeyCode.J))
        {
            KeyDowncheck[3] = true;
        }
        else
        {
            KeyDowncheck[3] = false;
        }
        if (Input.GetKey(KeyCode.K))
        {
            KeyDowncheck[4] = true;
        }
        else
        {
            KeyDowncheck[4] = false;
        }
        if (Input.GetKey(KeyCode.L))
        {
            KeyDowncheck[5] = true;
        }
        else
        {
            KeyDowncheck[5] = false;
        }
    }

    private void Start()
    {
        Note_Speed = ManagerMent.instance.Note_Speed;
        NoteSpeed_by_change_point();
        music_start();
        sound_Up();
    }

    public void sound_Up()
    {
        hit.volume = 0.2f * ManagerMent.instance.SE;
        smallhit.volume = 0.2f * ManagerMent.instance.SE;
    }

    public void music_start()
    {
        switch(ManagerMent.instance.order)
        {
            case 0:
                SemyeongSong.SetActive(true);
                break;
            case 1:
                NyanCat.SetActive(true);
                break;
            case 2:
                BrainPower.SetActive(true);
                break;
            case 3:
                QueenAluett.SetActive(true);
                break;
            case 4:
                FreedomDive.SetActive(true);
                break;
        }
    }

    public void NoteSpeed_by_change_point()
    {
        for(int i = 0; i < 6; i++)
        {
            instantiateObjects[i].transform.Translate(0, Note_Speed * 4, 0);
            Note.transform.GetChild(0).localScale = new Vector3(Note_Speed / 5, 0.5f, 1);
        }
    }

    public void Combo_Up()
    {
        Combo += 1;
    }

    public void Combo_reset()
    {
        Combo = 0;
    }

    public void Perfect_Score()
    {
        Score += 500 * (Combo + 100) / 100;
        Score_Text.text = Score.ToString();
    }

    public void Great_Score()
    {
        Score += 300 * (Combo + 100) / 100;
        Score_Text.text = Score.ToString();
    }

    public void Good_Score()
    {
        Score += 200 * (Combo + 100) / 100;
        Score_Text.text = Score.ToString();
    }

    public void Bad_Score()
    {
        Score += 100 * (Combo + 100) / 100;
        Score_Text.text = Score.ToString();
    }

    public void Score_Reset()
    {
        Score = 0;
    }

    public void Player_HP_Bad_Down()
    {
        Player_HP -= 25;
        Player_HP_reorder();
        Player_GameOver();
    }

    public void Player_HP_Miss_Down()
    {
        Player_HP -= 50;
        Player_HP_reorder();
        Player_GameOver();
    }

    public void Player_HP_Heal()
    {
        if(Player_HP >= 900 & Player_HP <= 1000)
        {
            Player_HP = 1000;
        }
        else
        {
            Player_HP += 100;
        }
        
        Player_HP_reorder();
    }

    public void Player_HP_Reset()
    {
        Player_HP = 1000;
        Player_HP_reorder();
    }

    public void Player_HP_reorder()
    {
        HP_image.fillAmount = Player_HP * 0.001f;
    }

    public void Player_GameOver()
    {
        if(Player_HP <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Player_HP_Reset();
            Combo_reset();
            Score_Reset();
        }
    }
}
