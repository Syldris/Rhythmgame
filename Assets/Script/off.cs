using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class off : MonoBehaviour
{
    void Start()
    {
        if (ManagerMent.instance.order != 1)
        {
            gameObject.SetActive(false);
        }
    }
}
