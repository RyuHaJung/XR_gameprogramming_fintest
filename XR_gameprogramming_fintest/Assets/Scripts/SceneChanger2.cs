using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
{
    public void ChangeNextScene()
    {

        SceneManager.LoadScene(3);
    }
}
