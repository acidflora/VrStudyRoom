using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpInputObject : MonoBehaviour
{
    [SerializeField] protected GameObject walkingDots;
    [SerializeField] protected GameObject actionDots;
    [SerializeField] protected GameObject grabDots;
    [SerializeField] protected GameObject menuDots;
    public virtual void ShowMovingHelp()
    {
        HideAllDots();
        walkingDots.SetActive(true);
    }
    public virtual void ShowActionHelp()
    {
        HideAllDots();
        actionDots.SetActive(true);
    }
    public virtual void ShowGrabHelp()
    {
        HideAllDots();
        grabDots.SetActive(true);
    }
    public virtual void ShowMenuHelp()
    {
        HideAllDots();
        menuDots.SetActive(true);
    }
    public virtual void Hide()
    {

    }
    protected void HideAllDots()
    {
        walkingDots.SetActive(false);
        actionDots.SetActive(false);
        grabDots.SetActive(false);
        menuDots.SetActive(false);
    }
}
