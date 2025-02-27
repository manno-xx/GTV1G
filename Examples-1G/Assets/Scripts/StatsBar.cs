using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class StatsBar : MonoBehaviour
{
    private Image bar;
    [SerializeField] private Gradient colors;
    
    private void Awake()
    {
        bar = GetComponent<Image>();
        UpdateBar(1f);
    }

    public void UpdateBar(float newFillAmount)
    {
        bar.fillAmount = newFillAmount;
        bar.color = colors.Evaluate(newFillAmount);
    }
}
