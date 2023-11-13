using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Note_instantiate : MonoBehaviour
{
    [SerializeField] private GameObject Note;
    public int instantiate_num;
    public float time;

    private void Update()
    {
        StartCoroutine(Note_Ins());

        time += Time.deltaTime;

        if (time > 1.0f)
        {
            time = 0.0f;
            Noteinstantiate();
        }
    }
    void Noteinstantiate()
    {
        Instantiate(Note, this.gameObject.transform);

    }

    IEnumerator Note_Ins()
    {
        if (Input.GetKeyDown(KeyCode.S) && instantiate_num == 1 && GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().collision != null)
        {
            GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.D) && instantiate_num == 2 && GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().collision != null)
        {
            GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.F) && instantiate_num == 3 && GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().collision != null)
        {
            GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.J) && instantiate_num == 4 && GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().collision != null)
        {
            GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.K) && instantiate_num == 5 && GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().collision != null)
        {
            GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().NoteClick = true;
        }

        if (Input.GetKeyDown(KeyCode.L) && instantiate_num == 6 && GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().collision != null)
        {
            GameObject.Find("Judgment_line_" + instantiate_num).GetComponent<judgement_line>().NoteClick = true;
        }
        yield break;
    }

}
