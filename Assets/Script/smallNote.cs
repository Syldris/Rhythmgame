using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[SerializeField]
public class smallNote : MonoBehaviour
{
    public int Note_number;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Judgment") && Gamemanager.Instance.KeyDowncheck[Note_number])
        {
            StartCoroutine(Gamemanager.Instance.judgement_lines[Note_number].smallNote_clear(this.gameObject.transform.parent.gameObject)); 
        }
        if(collision.CompareTag("Cheat"))
        {
            StartCoroutine(Gamemanager.Instance.Cheat_lines[Note_number].smallNote_clear(this.gameObject.transform.parent.gameObject));
        }
    }


}
