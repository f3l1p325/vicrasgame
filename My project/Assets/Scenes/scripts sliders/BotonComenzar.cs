using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotonComenzar : MonoBehaviour
{
    public void EmpezarNivel(string Nombrenivel)
    {
        SceneManager.LoadScene(Nombrenivel);
    }


}