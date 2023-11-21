using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Miss_line : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perfect"))
        {
            StartCoroutine(judgement_line.Instance.MissPlayCoroutine("None"));
            Destroy(collision.gameObject.transform.parent.gameObject.transform.parent.gameObject);
        }
    }


}
