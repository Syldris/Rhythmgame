using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[System.Serializable]
public class judgement_line : MonoBehaviour
{
    public bool NoteClick = false;
    public GameObject collision;
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
            else
            {
                StartCoroutine(NonePlayCoroutine("None", Miss));
            }
        }
    }

    IEnumerator NotePlayCoroutine(string judgement,GameObject collision,GameObject effectobject)
    {
        Instantiate(Effect, this.gameObject.transform);
        Instantiate(effectobject, GameCanvas.transform);
        Debug.Log(judgement);
        Destroy(collision.gameObject.transform.parent.gameObject.transform.parent.gameObject);
        NoteClick = false;
        yield break;
    }

    IEnumerator NonePlayCoroutine(string judgement, GameObject effectobject)
    {
        Instantiate(effectobject, GameCanvas.transform);
        Debug.Log(judgement);
        NoteClick = false;
        yield break;
    }


}
