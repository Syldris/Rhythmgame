using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Rainbow_Text : MonoBehaviour
{
    [SerializeField]private Text RainbowText;

    void Start()
    {
        StartCoroutine(Rainbow());
    }

    IEnumerator Rainbow()
    {
        while(true)
        {
            RainbowText.color = new Color32(222, 255, 186, 255);
            yield return new WaitForSecondsRealtime(0.1f);
            RainbowText.color = new Color32(255, 217, 186, 255);
            yield return new WaitForSecondsRealtime(0.1f);
            RainbowText.color = new Color32(237, 186, 255, 255);
            yield return new WaitForSecondsRealtime(0.1f);
            RainbowText.color = new Color32(186, 255, 251, 255);
            yield return new WaitForSecondsRealtime(0.1f);
            RainbowText.color = new Color32(228, 255, 186, 255);
            yield return new WaitForSecondsRealtime(0.1f);
        }
    }
}
