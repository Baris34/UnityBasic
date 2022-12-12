using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScr : MonoBehaviour
{
   public void TekrarDene()
    {
        SceneManager.LoadScene(1);
    }

    public void AnaMenü()
    {
        SceneManager.LoadScene(0);
    }
}
