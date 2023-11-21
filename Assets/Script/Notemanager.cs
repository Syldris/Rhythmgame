using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Notemanager : MonoBehaviour
{
    [SerializeField] private List<GameObject> Judgment_Line_Objects;

    private void Update()
    {
        StartCoroutine(Note_Ins());
    }

    IEnumerator Note_Ins()
    {
        if (Input.GetKeyDown(KeyCode.S) && Judgment_Line_Objects[0].GetComponent<judgement_line>().collision != null)
        {
            Judgment_Line_Objects[0].GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.D) && Judgment_Line_Objects[1].GetComponent<judgement_line>().collision != null)
        {
            Judgment_Line_Objects[1].GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.F) && Judgment_Line_Objects[2].GetComponent<judgement_line>().collision != null)
        {
            Judgment_Line_Objects[2].GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.J) && Judgment_Line_Objects[3].GetComponent<judgement_line>().collision != null)
        {
            Judgment_Line_Objects[3].GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.K) && Judgment_Line_Objects[4].GetComponent<judgement_line>().collision != null)
        {
            Judgment_Line_Objects[4].GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.L) && Judgment_Line_Objects[5].GetComponent<judgement_line>().collision != null)
        {
            Judgment_Line_Objects[5].GetComponent<judgement_line>().NoteClick = true;
        }
        yield break;
    }
}
