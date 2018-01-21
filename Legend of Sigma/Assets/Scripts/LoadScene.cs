using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	void startGame()
    {
        SceneManager.LoadScene("game", LoadSceneMode.Single);
    }

    void endGame()
    {
        SceneManager.LoadScene("end", LoadSceneMode.Single);
    }
}
