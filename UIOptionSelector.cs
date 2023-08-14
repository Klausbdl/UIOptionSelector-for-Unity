using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIOptionSelector : MonoBehaviour
{
    public TextMeshProUGUI text;
    private List<Image> listElements = new List<Image>();
    public List<string> Options = new List<string>();
    int currentIndex;
    public UnityEvent<Int32> OnChange;
    [Header("Visual List")]
    public RectTransform listTransform;
    public Material mat;
    public Color color;


    private void Start()
    {
        for (int i = 0; i < Options.Count; i++)
        {
            listElements.Add(Instantiate(new GameObject().AddComponent<Image>(), listTransform));
        }

        for (int i = 0; i < listElements.Count; i++)
        {
            if(mat)
                listElements[i].material = mat;
            listElements[i].color = color;
        }
    }

    public void ChangeValue(bool add)
    {
        if(add) currentIndex++;
        else currentIndex--;

        if(currentIndex >= Options.Count) currentIndex = 0;
        if(currentIndex <= -1) currentIndex = Options.Count - 1;

        text.text = Options[currentIndex];
        UpdateList(currentIndex);

        OnChange.Invoke(currentIndex);
    }

    public void UpdateIndex(int index)
    {
        currentIndex = index;

        if (currentIndex >= Options.Count) currentIndex = 0;
        if (currentIndex <= -1) currentIndex = Options.Count - 1;

        text.text = Options[currentIndex];
        UpdateList(currentIndex);
    }

    void UpdateList(int index)
    {
        Color originalColor = new Color(listElements[0].color.r, listElements[0].color.g, listElements[0].color.b, 1);
        Color fadedColor = new Color(originalColor.r, originalColor.g, originalColor.b, .1f);
        for(int i = 0; i < listElements.Count; i++)
        {
            if(i == index)
                listElements[i].color = originalColor;
            else
                listElements[i].color = fadedColor;
        }
    }
}
