using simple_math_3_game;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text scoresText;
    private void Awake()
    {
        Manager.OnGameFinsihed += () =>
        {
            Instantiate(Resources.Load<Popup>("popup"), GameObject.Find("screen").transform).SetData(scoresText.text, () =>
            {
                Manager.Instance.SetDifficult(0);
                Manager.Instance.Start_Game();
            });
        };
    }

    private void Start()
    {
        Manager.Instance.SetDifficult(0);
        Manager.Instance.Start_Game();
    }
}
