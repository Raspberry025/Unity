using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hint : MonoBehaviour
{
    public void HintLevel()
    {
        SceneManager.LoadScene(5);  // Corrected 'Loadscene' to 'LoadScene'
    }
}
