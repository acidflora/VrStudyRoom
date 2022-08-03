using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _table;
    [SerializeField] private GameObject _battery;
    [SerializeField] private GameObject _amper;
    protected override void CheckActions(int number)
    {

        if (number == 0)
        {
            teleportController.TeleportToActionPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.MeasureIconHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.MeasureIconTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.MeasureIconTextAction);
            helpInputObject.ShowActionHelp();
            _table.SetActive(true);
            _battery.SetActive(true);
        }
        else if (number == 1)
        {
            StartCoroutine(EndStep());
        }

    }
    private IEnumerator EndStep()
    {
        yield return new WaitForSeconds(4f);
        helpInputObject.Hide();
        _table.SetActive(false);
        _battery.SetActive(false);
        _amper.SetActive(false);
        ShupController shup = FindObjectOfType<ShupController>();
        shup.ResetShupPosition();
        EndScenarioStepEvent?.Invoke();
    }
}
