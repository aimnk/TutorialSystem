/// <summary>
/// Интерфейс сохранения\загрузки
/// </summary>
public interface ISaveLoad
{
    /// <summary>
    /// Сохранить данные
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    public abstract void Save<T> (T data);

    /// <summary>
    /// Загрузить данные
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public abstract T Load<T>();
}
