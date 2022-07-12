using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeasureCheckController : MonoBehaviour
{
    [SerializeField] private Ampermetr _amper;
    [SerializeField] private ShupController _shupController;
    [SerializeField] private StrelkaRotator _strelkaRotator;
    [SerializeField] private GameObject _amperButton;
    private string _measureText = "";

    private void OnEnable()
    {
        _shupController.SetMeasureTextEvent += OnShupConnected;
    }
    private void OnDisable()
    {
        _shupController.SetMeasureTextEvent -= OnShupConnected;
    }

    private void OnShupConnected(string text)
    {
        if(_shupController.ReturnMeasure())
        {
            _measureText = text;
            _amper.SetCondition(9);
        }
        else
        {
            _measureText = text;
            CheckMeasure(_measureText); 
            _measureText = "";
        }
    
    

    }
    private void CheckMeasure(string value)
    {
        if (value == "+ -")
        {
            _amperButton.SetActive(false);
            _shupController.CanMeasure = false;
            _strelkaRotator.RotateStrelka(true);
            ScenarioStepController controller = FindObjectOfType<ScenarioStepController>();
            controller.GetCurrentScenarioStep().StartAction();
        }

        else if (value == "- +")
        {
            _strelkaRotator.RotateStrelka(false);
    
        }
        else
        {
            _strelkaRotator.ResetStrelka();
      
        }
     
    }
}
