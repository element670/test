using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AddDatabaseButton : MonoBehaviour
{
    public static readonly string ACTION = "ADD_DB_BUTTON";

    [SerializeField] private Button _button;

    private void Awake()
    {
        _button.onClick.AddListener(() =>
        {
            Debug.Log(ACTION);
            EventBus.Trigger(ACTION, _button);
        });
    }
}
