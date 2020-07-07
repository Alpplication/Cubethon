using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moved : MonoBehaviour
{

    Rigidbody rb;

    public float forwardForce;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Baslangicta (Obstacle objeleri icerisinden) girilen engel hizina gore, engellerin kullanici uzerine hareketini saglar.
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        // Player uzerine gelen engel Player arkasina sabitlenen engel ile carpisirsa(veya herhangi bir engele temas ederse,ust uste gelme durumu) baslangicta belirlenen
        // konumda verilecek rastgele x degerine gore tekrar konumlanir ve Player uzerine harekete gecer.
        if (collisionInfo.collider.tag == "Obstacle")
        {
            gameObject.transform.position = new Vector3(Random.Range(-5, 5), 1, 25);
        }
    }
}
