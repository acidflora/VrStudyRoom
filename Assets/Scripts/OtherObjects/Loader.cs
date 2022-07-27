using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Loader : MonoBehaviour
{
    [SerializeField] private ScenarioStepController _scenarioStepController;

    [SerializeField] private GameObject _loader;
    [SerializeField] private Sprite _10;
    [SerializeField] private Sprite _30;
    [SerializeField] private Sprite _60;
    [SerializeField] private Sprite _75;
    [SerializeField] private Sprite _99;
    [SerializeField] private Sprite _100;

    public void StartLoading(float time)
    {
        _loader.SetActive(true);
        StartCoroutine(LoaderCo(time));
    }
    private IEnumerator LoaderCo(float time)
    {

        ChangeSprite(_10);
        yield return new WaitForSeconds(time);
        ChangeSprite(_30);
        yield return new WaitForSeconds(time);
        ChangeSprite(_60);
        yield return new WaitForSeconds(time);
        ChangeSprite(_75); ;
        yield return new WaitForSeconds(time);
        ChangeSprite(_99);
        yield return new WaitForSeconds(time);
        ChangeSprite(_100);
        yield return new WaitForSeconds(time);
        _loader.SetActive(false);
        LoadingDone();
    }
    private void ChangeSprite(Sprite sprite)
    {
        _loader.GetComponent<SpriteRenderer>().sprite = sprite;
    }
    private void LoadingDone()
    {
        _scenarioStepController.GetCurrentScenarioStep().StartAction();
    }    

}
