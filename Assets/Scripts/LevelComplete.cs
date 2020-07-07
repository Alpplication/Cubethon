using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public void LoadNextLevel()
    {
        // Aktif bolum tamamlandiktan sonra sonraki bolume(ekrana) gecilir.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
