using UnityEngine;
using TMPro; // Для работы с текстом

public class WinZone : MonoBehaviour
{
    // Сюда мы перетащим наш объект Текста из инспектора
    public TextMeshProUGUI winText;

    void Start()
    {
        // В начале игры текст победы должен быть скрыт
        if (winText != null)
            winText.gameObject.SetActive(false);
    }

    // Этот метод сработает, когда шарик влетит в зону финиша
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Проверяем, что в финиш влетел именно объект с тегом "Player" или просто с Rigidbody
        if (other.GetComponent<Rigidbody2D>() != null)
        {
            Debug.Log("Финиш достигнут!");

            if (winText != null)
            {
                winText.text = "ПОБЕДА!";
                winText.gameObject.SetActive(true); // Показываем текст на экране
            }

            // Опционально: останавливаем время в игре
            Time.timeScale = 0;
        }
    }
}