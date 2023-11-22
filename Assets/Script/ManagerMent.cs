using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMent : MonoSigleton<ManagerMent>
{
    private void Start()
    {
        DontDestroyOnLoad(this);
    }


}
