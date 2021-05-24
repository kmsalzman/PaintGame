using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene(3);
    }
}
