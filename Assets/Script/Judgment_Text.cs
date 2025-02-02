using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Judgment_Text : MonoSigleton<Judgment_Text>
{
    [SerializeField]private RectTransform Recform;

    private void Start()
    {
        StartCoroutine(DelayDestroy());
        Recform = this.gameObject.GetComponent<RectTransform>();
        
    }
    private void FixedUpdate()
    {
        Recform.Translate(new Vector3(0, 0.05f, 0));
    }
    
    IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(this.gameObject);
    }


}
