using UnityEngine;
using UnityEngine.UI;

public class PlayerNameInputField : MonoBehaviour {

    public InputField InputField;

    void Start() {
        var randomPlayerNumber = Random.Range(1000, 9999);
        InputField.text = $"Player{randomPlayerNumber}";
    }

}
