using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[SerializeField]
public class Gamemanager : MonoSigleton<Gamemanager>
{
    [SerializeField] public float Note_Speed;
    [SerializeField] private List<GameObject> instantiateObjects;
    [SerializeField] private GameObject Judgement_line;
    public bool Text_instantiate;
    public bool Judgement_instantiate;
    public int Combo;


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



}
