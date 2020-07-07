using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {
        // Kamera, Player i baslangicta(Main Camera objesi icerisinden) girilen degerler mesafesinde takip eder.
        transform.position = player.position + offset;
    }
}
