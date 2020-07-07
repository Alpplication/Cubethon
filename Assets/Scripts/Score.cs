using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;

    private int scoreCount;
    private float tempCount;
    public int scoreLimitCount;

    void Start()
    {
        
    }
    
    void Update()
    {
        // Float sayaci artirip integer deger olarak ekrana yazdiriyor.
        // Score sure bazinda ve saniyenin 2 kati olarak artmaktadir.
        tempCount += 2*Time.deltaTime;
        scoreCount = (int)tempCount;
        scoreText.text = scoreCount.ToString();

        if(scoreCount == scoreLimitCount) // Baslangicta (Canvas-> Score objesi icerisinden) girilen score limitine gore bolumu surdurur.
        {
            FindObjectOfType<GameManager>().CompleteLevel(); // Level Complete animasyonu tetiklenir.
        }
    }
}
