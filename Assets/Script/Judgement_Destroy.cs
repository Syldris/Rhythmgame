using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judgement_Destroy : MonoBehaviour
{
    [SerializeField] private bool Destroy_Text_Bool;
    void Start()
    {
        Gamemanager.Instance.Judgement_instantiate = !Gamemanager.Instance.Judgement_instantiate;
        Destroy_Text_Bool = Gamemanager.Instance.Judgement_instantiate;
    }

    void Update()
    {
        if (Destroy_Text_Bool != Gamemanager.Instance.Judgement_instantiate)
        {
            Destroy(this.gameObject);
        }
    }
}
