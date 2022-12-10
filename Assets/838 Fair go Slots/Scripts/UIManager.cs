using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void Start()
    {
        simple_math_3_game.Manager.Instance.SetDifficult(0);
        simple_math_3_game.Manager.Instance.Start_Game();
    }
}
