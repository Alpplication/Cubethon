using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float sidewaysForce = 500f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        // D tusuna basildiginda baslangicta(Player objesi icerisinden) girilen degere gore Player saga kayar.
        if (Input.GetKey("d")){

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        // A tusuna basildiginda baslangicta(Player objesi icerisinden) girilen degere gore Player sola kayar.
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        // Player kutusunun yuksekligi hic degismiyor ancak dusme gibi durumlarda degisebilir ve boyle durumlarda bolum yeniden baslamasi icin EndGame methodu cagirilir.
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
