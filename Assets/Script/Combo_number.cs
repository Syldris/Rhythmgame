using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Combo_number : MonoBehaviour
{
    [SerializeField] private Text Combo_Text;
    [SerializeField] private bool Destroy_Text_Bool;
    // Start is called before the first frame update
    void Start()
    {
        Gamemanager.Instance.Text_instantiate = !Gamemanager.Instance.Text_instantiate;
        Destroy_Text_Bool = Gamemanager.Instance.Text_instantiate;
        Combo_Text.text = Gamemanager.Instance.Combo.ToString() + "Combo!";
    }

    private void Update()
    {
        if(Destroy_Text_Bool != Gamemanager.Instance.Text_instantiate)
        {
            Destroy(this.gameObject);
        }
    }

}
