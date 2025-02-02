using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Miss_line : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector3(transform.position.x,(transform.position.y - Gamemanager.Instance.Note_Speed * 0.2f), transform.position.z);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perfect") || collision.CompareTag("Heal"))
        {
            StartCoroutine(judgement_line.Instance.MissPlayCoroutine("None"));
            Destroy(collision.gameObject.transform.parent.gameObject.transform.parent.gameObject);
            Scoremanager.Instance.Miss_plus();
        }
    }


}
