using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour {

	public void IrAEscena(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void salir(){
        Application.Quit();
    }
}
