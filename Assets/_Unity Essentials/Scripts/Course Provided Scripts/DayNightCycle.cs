using UnityEngine;

[ExecuteAlways] // Додає підтримку в Editor'і без запуску гри
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Скільки секунд займає повний оберт дня (360 градусів).")]
    public float dayLengthInSeconds = 60f;

    void Update()
    {
        if (dayLengthInSeconds <= 0) return;

        // Обчислюємо кут обертання для цього кадру
        float rotationPerFrame = 360f / dayLengthInSeconds * Time.deltaTime;

        // Обертаємо світло навколо осі X
        transform.Rotate(Vector3.right, rotationPerFrame);
    }
}
