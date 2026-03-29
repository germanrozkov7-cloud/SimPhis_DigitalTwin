using UnityEngine;

public class SimPhis_Code : MonoBehaviour
{
    public float force = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Проверяем, есть ли у объекта компонент физики, и толкаем его
            if (GetComponent<Rigidbody2D>() != null)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 1) * force, ForceMode2D.Impulse);
            }
        }
    }
}