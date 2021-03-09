using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AttributeBoard : MonoBehaviour {
    public Text dodge; // 闪避率
	public Text strike; // 暴击率
	public Text precise; // 精准率
	public Text life; // 生命值
	public Text attack; // 攻击力
	public Text defend; // 防御力 

	public void SetText(string type, int value) {
		switch (type) {
			case "dodge":
				dodge.text = "闪避:" + value.ToString() + "%";
				break; 
			case "strike":
				strike.text = "暴击:" + value.ToString() + "%";
				break; 
			case "precise":
				precise.text = "精准:" + value.ToString() + "%";
				break; 
			case "life":
				life.text = "生命值:" + value.ToString();
				break; 
			case "attack":
				attack.text = "攻击力:" + value.ToString();
				break; 
			case "defend":
				defend.text = "防御力:" + value.ToString();
				break; 
			default:
				break; 
		}
		
	}
}
