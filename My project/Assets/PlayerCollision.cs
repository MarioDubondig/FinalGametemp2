using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // L�gica de colisi�n con obst�culo
            // ...
            
            // Mostrar mensaje de Game Over
            GameOver.Show();
        }
    }
}
