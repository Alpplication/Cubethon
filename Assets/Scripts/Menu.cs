using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartGame()
    {
        // Oyun acildiktan sonra Start butonuna basilinca 1.leveli baslatir.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
