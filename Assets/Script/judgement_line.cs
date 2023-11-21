using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[System.Serializable]
public class judgement_line : MonoSigleton<judgement_line>
{
    public bool NoteClick = false;
    public GameObject collision;
    [SerializeField] private GameObject Combo_Object;
    [SerializeField] private GameObject Effect;
    [SerializeField] private GameObject Perfect;
    [SerializeField] private GameObject Great;
    [SerializeField] private GameObject Good;
    [SerializeField] private GameObject Bad;
    [SerializeField] private GameObject Miss;
    [SerializeField] private GameObject GameCanvas;

    private void OnTriggerEnter2D(Collider2D col)
    {
        collision = col.gameObject;
        if (collision.CompareTag("Miss"))
        {
            collision = null;
        }
    }

    
    private void Update()
    {
        if (NoteClick)
        {
            if (collision.CompareTag("Perfect"))
            {
                StartCoroutine(NotePlayCoroutine("Perfect", collision.gameObject,Perfect));
            }
            else if (collision.CompareTag("great"))
            {
                StartCoroutine(NotePlayCoroutine("Great", collision.gameObject,Great));
            }
            else if (collision.CompareTag("Good"))
            {
                StartCoroutine(NotePlayCoroutine("Good", collision.gameObject,Good));
            }
            else if (collision.CompareTag("Bad"))
            {
                StartCoroutine(NotePlayCoroutine("Bad", collision.gameObject,Bad));
            }
        }

    }

    IEnumerator NotePlayCoroutine(string judgement,GameObject collision,GameObject effectobject)
    {
        Instantiate(Effect, this.gameObject.transform);
        Instantiate(effectobject, GameCanvas.transform);
        if(judgement == "Perfect" || judgement == "Great")
        {
            Gamemanager.Instance.Combo_Up();
            Instantiate(Combo_Object, GameCanvas.transform);
        }
        else
        {
            Gamemanager.Instance.Combo_reset();
        }
        Debug.Log(judgement);
        Destroy(collision.gameObject.transform.parent.gameObject.transform.parent.gameObject);
        NoteClick = false;
        yield break;
    }

    public IEnumerator MissPlayCoroutine(string judgement)
    {
        Instantiate(Miss, GameCanvas.transform);
        Gamemanager.Instance.Combo_reset();
        Debug.Log(judgement);
        NoteClick = false;
        yield break;
    }


}
