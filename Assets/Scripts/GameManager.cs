using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Level1 _level1;
    [SerializeField] private Level2 _level2;
    [SerializeField] private Canvas _gameCompleteCanvas;

    private bool _isCompleteGame;
    
    private void Update()
    {
        if (!_isCompleteGame && _level1.IsComplete && _level2.IsComplete)
        {
            _isCompleteGame = true;
            _gameCompleteCanvas.gameObject.SetActive(true);
            Debug.Log("GAME COMPLETE!");
        }
    }
}
