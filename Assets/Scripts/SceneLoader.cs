using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour {

    public void LoadScn1()
    {
        SceneManager.LoadScene("Scn1");
    }
    public void LoadScn2()
    {
        SceneManager.LoadScene("Scn2");
    }
}
