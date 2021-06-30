using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start_gamemanager : MonoBehaviour
{
      public void toscene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
