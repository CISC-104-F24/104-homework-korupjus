using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.Examples;
using JetBrains.Annotations;



public class Buttons : MonoBehaviour
{
    public float cardCost = 2;
    public string cardName;
    public string cardDescription;
    public float totalStrength = 0;
    public float mainDamage = 6;
    public float additionalDamage = 0;
    public float totalStrikes = 0;
    public float strikeMultiplier = 2;
    
    public TextMeshProUGUI cardDescriptionUI;
    public TextMeshProUGUI cardNameUI;
    public TextMeshProUGUI cardCostUI;
    
    
    // Start is called before the first frame update
    void Start()
    {
        cardDescription = "Deal " + (mainDamage + totalStrength + additionalDamage) + ". Deals " + strikeMultiplier + " additional damage for ALL your cards containing \"Strike\".";
        cardDescriptionUI.text = cardDescription;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log (cardCost);
        Debug.Log (cardDescription);
        Debug.Log(totalStrikes);
        Debug.Log(totalStrength);
        Debug.Log(mainDamage);
        
        


    }
    public void CardName()
    {
        cardName = "Perfected Strike";
        cardNameUI.text = cardName;
    }
    public void CardCost()
    {
        cardCost--;
        if (cardCost < 0) 
        {
            cardCost = 0; 
        }

        cardCostUI.text = cardCost.ToString();
        
        
    }
    public void CardDescription()
    {
        
        cardDescription = "Deal " + (mainDamage + totalStrength + additionalDamage)  + ". Deals " + strikeMultiplier + " additional damage for ALL your cards containing \"Strike\".";
        cardDescriptionUI.text = cardDescription;
    }
    public void Upgrade()
    {
        cardName = "Perfected Strike+";
        cardNameUI.text = cardName;
        mainDamage = 9;
        strikeMultiplier = 3;
        mainDamage = (totalStrikes * strikeMultiplier) + mainDamage;
        cardDescription = "Deal " + (mainDamage + totalStrength + additionalDamage) +". Deals " + strikeMultiplier + " additional damage for ALL your cards containing \"Strike\".";
        cardDescriptionUI.text = cardDescription;
    }
    public void GainStrength(int Strength) 
    {
        totalStrength = totalStrength + Strength;
        cardDescription = "Deal " + (mainDamage + totalStrength + additionalDamage) + ". Deals " + strikeMultiplier + " additional damage for ALL your cards containing \"Strike\".";
        cardDescriptionUI.text = cardDescription;
    }
    public void AddStrikes()
    {
        totalStrikes++;
        additionalDamage = additionalDamage + (totalStrikes * strikeMultiplier);
        cardDescription = "Deal " + (mainDamage + totalStrength + additionalDamage) + ". Deals " + strikeMultiplier + " additional damage for ALL your cards containing \"Strike\".";
        cardDescriptionUI.text = cardDescription;
    }
    public void ChangeColor()
    {
        cardNameUI.color = Color.green;
    }
}
