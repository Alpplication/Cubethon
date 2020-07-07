using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        // Eger temas edilen deger bir engel ise aktif olur.
        if(collisionInfo.collider.tag == "Obstacle")
        {
            // Player in hareketini durdurur ve bolumu yeniden baslatir.
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

