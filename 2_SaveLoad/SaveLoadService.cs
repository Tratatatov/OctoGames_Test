using System;
using System.IO;
using UnityEngine;

public static class SaveLoadService
{
    private static readonly string SaveDirectory = Application.persistentDataPath;

    public static void Save<T>(T data, string key) where T : class
    {
        try
        {
            string path = GetPath(key);
            string json = JsonUtility.ToJson(data, prettyPrint: true);
            File.WriteAllText(path, json);
            Debug.Log($"[SaveService] Saved '{key}' to: {path}");
        }
        catch (Exception e)
        {
            Debug.LogError($"[SaveService] Failed to save '{key}': {e.Message}");
        }
    }

    public static T Load<T>(string key) where T : class, new()
    {
        string path = GetPath(key);

        if (!File.Exists(path))
            return new T();

        try
        {
            string json = File.ReadAllText(path);
            T data = JsonUtility.FromJson<T>(json);
            Debug.Log($"[SaveService] Loaded '{key}' from: {path}");
            return data ?? new T();
        }
        catch (Exception e)
        {
            Debug.LogError($"[SaveService] Failed to load '{key}': {e.Message}");
            return new T();
        }
    }

    public static bool TryLoad<T>(string key, out T data) where T : class, new()
    {
        string path = GetPath(key);

        if (!File.Exists(path))
        {
            data = null;
            return false;
        }

        try
        {
            string json = File.ReadAllText(path);
            data = JsonUtility.FromJson<T>(json);
            return data != null;
        }
        catch (Exception e)
        {
            Debug.LogError($"[SaveService] Failed to load '{key}': {e.Message}");
            data = null;
            return false;
        }
    }

    public static void Delete(string key)
    {
        string path = GetPath(key);
        if (File.Exists(path))
            File.Delete(path);
    }

    public static bool Exists(string key) => File.Exists(GetPath(key));

    private static string GetPath(string key) =>
        Path.Combine(SaveDirectory, $"{key}.json");
}
