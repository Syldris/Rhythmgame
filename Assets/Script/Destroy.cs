using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Judgment"))
        {
            StartCoroutine(judgement_line.Instance.MissPlayCoroutine("Destroy"));
            Destroy(this.gameObject.transform.parent.gameObject);
        }
    }
}
