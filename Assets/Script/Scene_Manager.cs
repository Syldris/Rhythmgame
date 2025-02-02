using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Manager : MonoBehaviour
{
    public void SceneMove_Mainmenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Game_Exit()
    {
        Application.Quit();
    }

    public void SceneMove_ReGame()
    {
        ManagerMent.instance.GameStart(ManagerMent.instance.order);
    }
}
