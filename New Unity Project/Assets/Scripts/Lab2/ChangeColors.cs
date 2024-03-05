using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColors : MonoBehaviour
{
    public Image targetImage; // ссылка на объект Image
    public Color[] colors; // массив цветов
    private int currentIndex; // текущий индекс цвета

    private int countCubes = 0; // количество кубов по умолчанию

    void Start()
    {
        Debug.Log("Start");

        currentIndex = 0;

        colors = new Color[]
        {
            Color.red,
            Color.green,
            Color.blue,
            new Color(1f, 1f, 0f), // желтый
            new Color(0.5f, 0f, 0.5f) // фиолетовый
        };

        // Установите начальный цвет
        if (targetImage != null && colors.Length > 0)
        {
            targetImage.color = colors[currentIndex];
        }
        else
        {
            Debug.LogError("Заполни цвета чел");
        }
    }

    public void ChangeColorLeft()
    {
        // Переключение на предыдущий цвет
        currentIndex = (currentIndex - 1 + colors.Length) % colors.Length;
        UpdateColor();
    }

    public void ChangeColorRight()
    {
        // Переключение на следующий цвет
        currentIndex = (currentIndex + 1) % colors.Length;
        UpdateColor();
    }

    public void SetCountCubes1()
    {
        // Установка значения countCubes при нажатии кнопок с цифрами
        countCubes = 1;
    }

    public void SetCountCubes2()
    {
        // Установка значения countCubes при нажатии кнопок с цифрами
        countCubes = 3;
    }

    public void SetCountCubes3()
    {
        // Установка значения countCubes при нажатии кнопок с цифрами
        countCubes = 10;
    }

    public void CreateCubes()
    {
        // Создание кубов с установленным цветом и количеством
        Vector3 startPosition = new Vector3(248f, 220f, 150f);
        for (int i = 0; i < countCubes; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = startPosition + new Vector3(60f * (i+2), 0f, 0f);
            cube.transform.localScale = new Vector3(50f, 50f, 50f);
            cube.GetComponent<Renderer>().material.color = colors[currentIndex];
        }
    }

    private void UpdateColor()
    {
        // Обновление цвета изображения
        if (targetImage != null && colors.Length > 0)
        {
            targetImage.color = colors[currentIndex];
        }
    }
}
