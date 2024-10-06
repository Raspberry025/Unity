using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BButton : MonoBehaviour
{
   public void BackBut()
    {
        SceneManager.LoadScene(6);
    }
}
