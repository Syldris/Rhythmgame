using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    [SerializeField] private int order;

    public List<GameObject> Helplist;


    public GameObject panel;


    public void panelOpen()
    {
        panel.SetActive(true);
    }

    public void panelfalse()
    {
        panel.SetActive(false);
    }

    public void LeftArrowButton()
    {
        if (order > 0)
        {
            Helplist[order].SetActive(false);
            order -= 1;
            Helplist[order].SetActive(true);
        }
        else
        {
            Helplist[order].SetActive(false);
            order = Helplist.Count - 1;
            Helplist[order].SetActive(true);
        }
    }
    public void RightArrowButton()
    {
        if (order < Helplist.Count - 1)
        {
            Helplist[order].SetActive(false);
            order += 1;
            Helplist[order].SetActive(true);
        }
        else
        {
            Helplist[order].SetActive(false);
            order = 0;
            Helplist[order].SetActive(true);
        }
    }
}
