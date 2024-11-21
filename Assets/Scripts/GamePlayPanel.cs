

using System;
using Game;
using dotmob;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayPanel : ShowHidable
{
    [SerializeField] private Text _lvlTxt;
    [SerializeField] private Text txtTutorial;

    private void Start()
    {
        _lvlTxt.text = $" LEVEL\n {LevelManager.Instance.Level.no}";

        //Debug.Log("Level :" + LevelManager.Instance.Level.no);
    }

    public void OnClickUndo()
    {
        LevelManager.Instance.OnClickUndo();
    }

    public void OnClickRestart()
    {
        GameManager.LoadGame(new LoadGameData
        {
            Level = LevelManager.Instance.Level,
            GameMode = LevelManager.Instance.GameMode,
        },false);
    }

    public void OnClickMenu()
    {
        //SharedUIManager.PopUpPanel.ShowAsConfirmation("PAUSE", "Are you sure want to exit the game?", success =>
        // {
        //     if (!success)
        //         return;

        //     GameManager.LoadScene("MainMenu");
        // });

        SharedUIManager.PausePanel.Show();

    }

    private void Update()
    {
    }
}