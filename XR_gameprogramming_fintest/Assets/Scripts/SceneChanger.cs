using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeNextScene()
    {

        SceneManager.LoadScene(2);
        //SceneManager..LoadScene("03.Sample");
    }
}
