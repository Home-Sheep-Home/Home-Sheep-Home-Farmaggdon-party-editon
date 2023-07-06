using UnityEngine;

public class LevelLoader : MonoBehaviour
{
	public bool levelStarted;
	public bool levelComplete;
	public bool levelFailed;
	public bool levelLoaded;
	public bool levelRestarted;
	public int levelAttempts;
	public bool HSH1;
	public LoadingScreen loadingScreen;
	public int levelNumber;
	public string levelId;
	public LevelUI levelUI;
	public bool restartAllowed;
}
