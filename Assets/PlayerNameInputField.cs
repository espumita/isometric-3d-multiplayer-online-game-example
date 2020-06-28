using UnityEngine;
using UnityEngine.UI;

public class PlayerNameInputField : MonoBehaviour {

    public InputField InputField;

    void Start() {
        var range = Random.Range(1000, 9999);
        InputField.text = $"Player{range}";
    }

}
