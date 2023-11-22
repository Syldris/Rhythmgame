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
    [SerializeField] private GameObject Judgement_line;
    [SerializeField] private Text Score_Text;
    [SerializeField] private int Player_HP;
    [SerializeField] private Image HP_image;
    public bool Text_instantiate;
    public bool Judgement_instantiate;
    public int Combo;
    public int Score;


    private void Start()
    {
        NoteSpeed_by_change_point();
    }

    public void NoteSpeed_plus()
    {
        Note_Speed += 0.1f;
    }
    public void NoteSpeed_plus_plus()
    {
        Note_Speed += 1.0f;
    }
    public void NoteSpeed_minus()
    {
        Note_Speed -= 0.1f;
    }
    public void NoteSpeed_minus_minus()
    {
        Note_Speed -= 1.0f;
    }

    public void NoteSpeed_by_change_point()
    {
        for(int i = 0; i < 6; i++)
        {
            instantiateObjects[i].transform.Translate(0, Note_Speed * 4, 0);
            Judgement_line.transform.GetChild(0).localScale = new Vector3(Note_Speed / 5, 0.5f, 1);
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
