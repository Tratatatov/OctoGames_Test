using UnityEngine;

public class PlayerDataController : MonoBehaviour
{
    private PlayerData _playerData;

    public void SavePlayerData()
    {
        SaveLoadService.Save(_playerData, nameof(PlayerData));
    }

    public void LoadPlayerData()
    {
        _playerData = SaveLoadService.Load<PlayerData>(nameof(PlayerData));
    }

    public void DeletePlayerData()
    {
        SaveLoadService.Delete(nameof(PlayerData));
        _playerData = new PlayerData();
    }

    public bool PlayerDataExists()
    {
        return SaveLoadService.Exists(nameof(PlayerData));
    }
}

[System.Serializable]
public class PlayerData
{
    public string Name = "";
    public int Level = 0;
    public int SomeValue = 0;
    public bool SomeFlag = false;
}
