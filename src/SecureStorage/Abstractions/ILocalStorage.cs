namespace SecureStorage.Abstractions;

/// <summary>
/// Provides mechanisms for storing and retrieving persistent data across application restarts.
/// In Blazor WebApp: Uses browser localStorage.
/// In MAUI: Uses native Preferences API.
/// </summary>
public interface ILocalStorage
{
    /// <summary>
    /// Asynchronously stores the specified data.
    /// </summary>
    ValueTask SetAsync(string key, object? value);

    /// <summary>
    /// Gets asynchronously the specified data.
    /// </summary>
    ValueTask<BrowserStorageResult<TValue>> GetAsync<TValue>(string key);

    /// <summary>
    /// Deletes asynchronously any data stored for the specified key.
    /// </summary>
    ValueTask DeleteAsync(string key);

    /// <summary>
    /// Clears all stored data.
    /// </summary>
    ValueTask ClearAsync();

    /// <summary>
    /// Checks if a key exists in storage.
    /// </summary>
    ValueTask<bool> ContainsKeyAsync(string key);
}