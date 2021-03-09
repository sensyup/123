using UnityEngine;
using System.Collections;

public class BattleGUI : MonoBehaviour {

	BattleController controller;
	public GameObject timeLine;
	public Canvas ActionsMenuCanvas;
	public Canvas AnnouncementsCanvas;
	public Canvas PreBattleCanvas;

	// public Canvas TimeLineCanvas;

	public float timeLineLength;

	void Start(){
		controller = gameObject.GetComponent<BattleController>();

		if (ActionsMenuCanvas == null)
			ActionsMenuCanvas = transform.Find ("ActionsMenuCanvas").gameObject.GetComponent<Canvas>();

		if (AnnouncementsCanvas == null)
			AnnouncementsCanvas = transform.Find ("AnnouncementsCanvas").gameObject.GetComponent<Canvas>();

		if (PreBattleCanvas == null)
			PreBattleCanvas = transform.Find ("PreBattleCanvas").gameObject.GetComponent<Canvas>();

		// if (TimeLineCanvas == null) {
		// 	TimeLineCanvas = transform.Find("TimeLineCanvas").gameObject.GetComponent<Canvas>(); 
		// }
		timeLineLength = timeLine.GetComponent<RectTransform>().rect.size.x;
		// Debug.Log(timeLineLength);
	}

	public float GetLength() {
		return timeLineLength;
	}
	public void Attack(){
		if (!controller.selectedUnit.hasAttacked){
			controller.grid.UnpaintAllFaces();
			
			controller.selectedUnit.state = UnitState.Attacking;
			controller.PaintFaces();
		}
	}

	public void Victory(){
		controller.announcements.animator.SetBool ("Victory", true);
		controller.announcements.text.text = "Victory!!!";
		controller.status = BattleStatus.Paused;
	}

	public void Defeat(){
		controller.announcements.animator.SetBool ("Defeat", true);
		controller.announcements.text.text = "Defeat...";
		controller.status = BattleStatus.Paused;
	}
}

public enum GUIStatus{
	ShowStart,
	ShowVictory,
	ShowDefeat,
	NotShowing
}
