using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
    private bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public void EndGame() {
        if(!gameHasEnded){
            gameHasEnded = true;
            Debug.Log("End");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart() {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel() {
        Debug.Log("Completed!");
        completeLevelUI.SetActive(true);  
    }
}
