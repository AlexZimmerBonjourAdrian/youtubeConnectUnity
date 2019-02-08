using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CGameManger : MonoBehaviour
{
    // Start is called before the first frame update
    public static CGameManger Inst
    {
        get
        {
            if(_inst == null)
            {
               GameObject obj = new GameObject("CGameManager");
                return obj.AddComponent<CGameManger>();
            }
            return _inst;
        }
    }
    private static CGameManger _inst;
    private AsyncOperation _currentLoadingScene;

    public void Awake()
    {
        if(_inst !=null && _inst != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
        _inst = this;
        
    }

    public void LateUpdate()
    {
        if(_currentLoadingScene != null)
        {
            if (_currentLoadingScene.isDone)
                _currentLoadingScene = null;
        }
    }
    public bool IsLoadingScene()
    {
        return _currentLoadingScene != null && !_currentLoadingScene.isDone;
    }
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void LoadSceneAsync(string name)
    {
        _currentLoadingScene = SceneManager.LoadSceneAsync(name);
    }
        
    public void LoadSceneAsyncAdditive(string name)
    {
        _currentLoadingScene = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
    }
    
}
