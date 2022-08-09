using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpgradeButton : MonoBehaviour
{
	public Button MyUpgradeButton;

	void Start()
	{
		Button btn_upgrade = MyUpgradeButton.GetComponent<Button>();
		btn_upgrade.onClick.AddListener(TaskOnClick);

	}

	void TaskOnClick()
	{
		
		//Debug.Log(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(2, LoadSceneMode.Single);
		//SceneManager.UnloadSceneAsync("Landing_Scene");
			
	}

}