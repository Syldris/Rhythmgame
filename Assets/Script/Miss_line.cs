using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miss_line : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Perfect"))
        {
            print("miss");
            Destroy(collision.gameObject.transform.parent.gameObject.transform.parent.gameObject);

        }
    }
}
