using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_instantiate : MonoBehaviour
{
    [SerializeField] private GameObject Note;
    [SerializeField] private GameObject smallNote;
    [SerializeField] private GameObject HealNote;
    public int instantiate_num;
    public float time;
    public bool Notebool;

    public void Ins_Note()
    {
        var note = ObjectPool.instance.Pool.Get();
        note.transform.position = this.gameObject.transform.position;
    }

    public void Small_Ins_Note()
    {
        var Smallnote = SmallObjectPool.instance.Pool.Get();
        Smallnote.transform.position = this.gameObject.transform.position;
        Smallnote.transform.GetChild(0).GetComponent<smallNote>().Note_number = instantiate_num;
    }

    public void Heal_Ins_Note()
    {
        Instantiate(HealNote,this.gameObject.transform);
    }
}
