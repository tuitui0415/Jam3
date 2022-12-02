using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int iLeveltoLoad;
    public string sLeveltoLoad;
    public bool useIntegerToLoadLevel = false;

    private void OnTriggerEnter2D(Collider2D collision) {
        GameObject collisionGameObject = collision.gameObject;
        if (collisionGameObject.name == "player") {
            LoadScene();
        } 
    }

    void LoadScene() {
        if (useIntegerToLoadLevel) {
            SceneManager.LoadScene(iLeveltoLoad);
        } else {
            SceneManager.LoadScene(sLeveltoLoad);
        }
    }

}
