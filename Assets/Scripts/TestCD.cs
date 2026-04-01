using System;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.UI;

public class TestCD : MonoBehaviour
{
    public Button quitButton;
    public Button throwExceptionButton;
    public Button forceCrashButton;
    public Button ooRErrorButton;
    public Button forceCrashAccessViolationButton;
    public Button nullReferenceErrorButton;
    public GameObject leaveEmpty;

    private void Start()
    {
        quitButton.onClick.AddListener(QuitApp);
        throwExceptionButton.onClick.AddListener(ThrowException);
        forceCrashButton.onClick.AddListener(ForceCrash);
        ooRErrorButton.onClick.AddListener(OORError);
        forceCrashAccessViolationButton.onClick.AddListener(ForceCrashAccessViolation);
        nullReferenceErrorButton.onClick.AddListener(NullReferenceTest);
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void ThrowException()
    {
        Debug.LogException(new Exception("Test Exception"));
    }

    public void ForceCrash()
    {
        Utils.ForceCrash(ForcedCrashCategory.FatalError);
    }

    public void ForceCrashAccessViolation()
    {
        Utils.ForceCrash(ForcedCrashCategory.AccessViolation);
    }

    public void OORError()
    {
        int[] testArray = new int[1];
        int goingToFail = testArray[2];
    }

    public void NullReferenceTest()
    {
        string willFail = leaveEmpty.name;
    }
}
