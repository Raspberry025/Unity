using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeScript : MonoBehaviour
{
    public void ResumeButton()
    {
        SceneManager.LoadScene(0);
    }
}
