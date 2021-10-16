using System;

namespace Core.Tools.Contracts
{
    /// <summary>
    /// Интерфейс для обёртывание освобождение ресурса
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// Copyright SotinNU aka VirRus77
    public interface IDisposableBag<T> : IDisposable
    {
        /// <summary>
        /// Хранимый ресурс
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Флаг запрета изменения <seealso cref="Value"/>
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Заменить хранимое значение
        /// </summary>
        /// <param name="newValue">Новое значение.</param>
        void ReplaceValue(T newValue);
    }
}
