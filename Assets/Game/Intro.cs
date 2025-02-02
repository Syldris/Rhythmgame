using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[SerializeField]
public class Intro : MonoBehaviour
{
    [SerializeField]private List<Note_instantiate> Notes;
    void Start()
    {
        StartCoroutine(IntroGame());
    }
    IEnumerator IntroGame()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Notes[0].Ins_Note();
            yield return new WaitForSeconds(0.5f);
            Notes[1].Ins_Note();
            yield return new WaitForSeconds(0.5f);
            Notes[2].Ins_Note();
            yield return new WaitForSeconds(0.5f);
            Notes[3].Ins_Note();
            yield return new WaitForSeconds(0.5f);
            Notes[4].Ins_Note();
            yield return new WaitForSeconds(0.5f);
            Notes[5].Ins_Note();
        }
    }
}
