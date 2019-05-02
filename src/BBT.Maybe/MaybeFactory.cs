﻿namespace BBT.Maybe
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Factory methods.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileNameShouldMatchFirstTypeName", Justification = "Factory method should be called Maybe.")]
    public static class Maybe
    {
        /// <summary>
        /// Creates an instance of <see cref="Maybe{T}"/> which may be null.
        /// </summary>
        /// <typeparam name="T">The reference type.</typeparam>
        /// <param name="aValue">The value which may be null.</param>
        /// <returns>The maybe.</returns>
        public static Maybe<T> Some<T>(T aValue)
            where T : class => new Maybe<T>(aValue);

        /// <summary>
        /// Creates an instance of Type <typeparamref name="T"/> which is null.
        /// </summary>
        /// <typeparam name="T">The reference type.</typeparam>
        /// <returns>The maybe representing none.</returns>
        public static Maybe<T> None<T>()
            where T : class => new Maybe<T>(null);

        /// <summary>
        /// Creates an instance of <see cref="Maybe{T}"/> which may be null.
        /// </summary>
        /// <typeparam name="T">The reference type.</typeparam>
        /// <param name="aValue">The value which may be null.</param>
        /// <returns>The maybe.</returns>
        public static MaybeStruct<T> SomeStruct<T>(T? aValue)
            where T : struct => new MaybeStruct<T>(aValue);

        /// <summary>
        /// Creates an instance of Type <typeparamref name="T"/> which is null.
        /// </summary>
        /// <typeparam name="T">The reference type.</typeparam>
        /// <returns>The maybe representing null.</returns>
        public static MaybeStruct<T> NoneStruct<T>()
            where T : struct => new MaybeStruct<T>(null);
    }
}
