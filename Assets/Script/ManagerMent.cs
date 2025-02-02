using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMent : MonoBehaviour
{
    public static ManagerMent instance;
    public List<GameObject> SongPlay;
    public float Note_Speed;
    public float offset;
    public float BGM;
    public float SE;
    public bool Cheat;
    public int order;

    public int SemyeongSongScore;
    public int NyanCatScore;
    public int BrainPowerScore;
    public int QueenAluettScore;
    public int FreedomDiveScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void GameStart(int order)
    {
        SceneManager.LoadScene("MainGame");
        SongPlay[order].gameObject.SetActive(true);
        
    }

}
