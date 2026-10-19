using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : IState
{
    // === メンバー変数 ===
    private SceneManager _sceneManager;
    private GameObject _gameCube;

    public void Enter()
    {
        Debug.Log($"{GetType().Name}が始まります。");

        // SceneManagerを取得
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();

        _gameCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // ゲーム画面に切り替える
            _sceneManager.ChangeScene(new GameSceneState());
        }
    }
    public void Exit()
    {
        Debug.Log($"{GetType().Name}が終了します。");

        GameObject.Destroy(_gameCube);
    }
}
