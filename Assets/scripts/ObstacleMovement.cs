using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 5.0f; // Ajusta la velocidad seg�n tu necesidad

    void Update()
    {
        // Mover el obst�culo hacia la izquierda (suponiendo que el jugador va hacia la derecha)
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Si el objeto sale de la pantalla, desactivarlo (o puedes usar un sistema de l�mites).
        if (transform.position.x < -10.0f) // Ajusta el valor dependiendo del tama�o de tu escena
        {
            gameObject.SetActive(false);
        }
    }
}
