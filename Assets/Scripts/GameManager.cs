using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    bool gameEndAgain = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    // Bolum gecilirse cagirilacak.
    public void CompleteLevel()
    {
        // Bolum bittikten sonra LevelComplete ekrani aktif edilir.
        if(gameEndAgain == false)
        {
            gameEndAgain = true;
            completeLevelUI.SetActive(true);
        }
    }

    public void EndGame()
    {
        // Bir kere yazdirmak icin bir kontrol.
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay); // gecikmeli fonksiyon cagiriyoruz.(ilk parametre fonksiyon adi, ikinci parametre bekle suresi)
        }
    }
    
    // Bolumu yeniden baslatir.
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
