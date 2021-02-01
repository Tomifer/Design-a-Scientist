using System;
using UnityEngine;
using UnityEngine.UI;
     
/**
    Makse the scroll feature work
    @author Anthony Bulthuis
    @author Thomas Batchelder
*/
public class Scroll : MonoBehaviour
{
    //The scroll bar
    public Scrollbar Target;
    //The button that the script is not placed on
    public Button TheOtherButton;
    //The step amount
    public float Step = 0.1f;
    
    /**
        Increments the bar
    */
    public void Increment()
    {
        if (Target == null || TheOtherButton == null) throw new Exception("Setup ScrollbarIncrementer first!");
        Target.value = Mathf.Clamp(Target.value + Step, 0, 1);
        TheOtherButton.interactable = true;
    }
     
    /**
        Decrements the bar
    */
    public void Decrement()
    {
        if (Target == null || TheOtherButton == null) throw new Exception("Setup ScrollbarIncrementer first!");
        Target.value = Mathf.Clamp(Target.value - Step, 0, 1);
        TheOtherButton.interactable = true;
    }
}
