using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
	public LevelLoader levelLoader;
	public Story_LevelCompletePopup levelCompletePopup;
	public Story_LevelFailedPopup levelFailedPopup;
	public GameObject touchUI;
	public HintScreen levelHintPanel;
	public Story_PausePopup pausePopup;
	public Story_QuitPopup quitPopup;
	public Story_SettingsPopup settingsPopup;
	public Story_ControlsScreen controlsPopup;
	public Story_ChapterCompletePopup chapterCompletePopup;
	public GameObject storySheepStatusDisplay;
	public Text levelName;
	public AutoSaveIcon autoSaveIcon;
}
