using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 5.0f; // Ajusta la velocidad según tu necesidad

    void Update()
    {
        // Mover el obstáculo hacia la izquierda (suponiendo que el jugador va hacia la derecha)
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Si el objeto sale de la pantalla, desactivarlo (o puedes usar un sistema de límites).
        if (transform.position.x < -10.0f) // Ajusta el valor dependiendo del tamaño de tu escena
        {
            gameObject.SetActive(false);
        }
    }
}
