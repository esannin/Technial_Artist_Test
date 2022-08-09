using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ReduceCurrency : MonoBehaviour
{
    private TextMeshProUGUI Cash;
    private int currency;
    [SerializeField]
    private CanvasGroup ButtonCancasGroup;
    public static ReduceCurrency Instance { get; private set; }

    private void Start()
    {
        currency = 1000;
        Cash = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than one instance of this class is created!" + transform + "-" + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    public void SubtractCurrency()
    {
        currency -= 10;
        if (currency < 0)
        {
            UpdateButtonVisibility(false);
            currency = 0;
        }
        else
        {
            UpdateButtonVisibility(true);
            Cash.text = currency.ToString();
        }
        
    }

    public void UpdateButtonVisibility(bool isInteractable)
    {
        if (!isInteractable)
        {
            //ButtonCancasGroup.alpha = 0.5f;
            ButtonCancasGroup.interactable = false;
        }
        else
        {
            //ButtonCancasGroup.alpha = 1f;
            ButtonCancasGroup.interactable = true;
        }
    }
        
}