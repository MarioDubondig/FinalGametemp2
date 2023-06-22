using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad del carro
    public float timeScale = 1f; // Escala del tiempo
    private bool gameIsOver = false; // Indicador de si el juego ha terminado

    private void FixedUpdate()
    {
        if (gameIsOver)
        {
            return;
        }

        float moveHorizontal = Input.GetAxisRaw("Horizontal"); // Entrada horizontal (izquierda/derecha) sin suavizado
        float moveVertical = Input.GetAxisRaw("Vertical"); // Entrada vertical (delante/atrás) sin suavizado

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime * timeScale);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameIsOver = true;
            GameOver.Show();
        }
    }
}
