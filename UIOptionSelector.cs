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
    public int currentIndex;
    public UnityEvent<Int32> OnChange;
    [Header("Visual List")]
    public RectTransform listTransform;
    public Material mat;
    public Color color;

    private void Start()
    {
        PopulateVisualList();
    }

    public void ClearAll()
    {
        Options.Clear();
        foreach (Image image in listElements)
        {
            Destroy(image.gameObject);
        }
        listElements.Clear();

        currentIndex = -1;
    } //use to clear everything, the current index is set to -1

    public void AddOptions(List<string> options) //use to dynamically add options
    {
        Options.AddRange(options);
    }

    private void PopulateVisualList()
    {
        if (Options.Count == 0) return;

        for (int i = 0; i < Options.Count; i++)
        {
            GameObject go = new GameObject();
            go.AddComponent<Image>();
            go.transform.SetParent(listTransform, false);
            listElements.Add(go.GetComponent<Image>());
        }

        for (int i = 0; i < listElements.Count; i++)
        {
            if(mat)
                listElements[i].material = mat;
            listElements[i].color = color;
        }

        UpdateList(currentIndex);
    }

    public void ChangeValue(bool add) //used by the two buttons inside the prefab
    {
        if (Options.Count == 0) return;

        if (add) currentIndex++;
        else currentIndex--;

        if(currentIndex >= Options.Count) currentIndex = 0;
        if(currentIndex < 0) currentIndex = Options.Count - 1;

        text.text = Options[currentIndex];
        UpdateList(currentIndex);

        OnChange.Invoke(currentIndex);
    }

    public void UpdateIndex(int index) //use this method when loading a setting, so it updates visually on the scene
    {
        currentIndex = index;

        if (Options.Count == 0) return;

        if (currentIndex >= Options.Count) currentIndex = 0;
        if (currentIndex <= -1) currentIndex = Options.Count - 1;

        text.text = Options[currentIndex];
        UpdateList(currentIndex);
    }

    void UpdateList(int index)
    {
        if (Options.Count == 0) return;
        if (listElements.Count == 0) return;

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
