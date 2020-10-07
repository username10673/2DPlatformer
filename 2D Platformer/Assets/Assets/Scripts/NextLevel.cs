using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{


    // Update is called once per frame
    public void Next(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);   
    }
}
