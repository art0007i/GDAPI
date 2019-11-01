﻿using GDAPI.Objects.DataStructures;

namespace GDAPI.Objects.Reflection
{
    /// <summary>Represents a dictionary of <seealso cref="CachedTypeInfo{TTypeKey, TPropertyKey}"/> objects.</summary>
    /// <typeparam name="TTypeKey">The type of the key that the type returns.</typeparam>
    /// <typeparam name="TPropertyKey">The type of the key that the type's properties return.</typeparam>
    public class CachedTypeInfoDictionary<TTypeKey, TPropertyKey> : KeyedObjectDictionary<TTypeKey, CachedTypeInfo<TTypeKey, TPropertyKey>>
    {
        /// <summary>Initializes a new instance of the <seealso cref="CachedTypeInfoDictionary{TTypeKey, TPropertyKey}"/> class.</summary>
        public CachedTypeInfoDictionary() : base() { }
        /// <summary>Initializes a new instance of the <seealso cref="CachedTypeInfoDictionary{TTypeKey, TPropertyKey}"/> class.</summary>
        /// <param name="d">The dictionary to initialize this dictionary out of.</param>
        public CachedTypeInfoDictionary(CachedTypeInfoDictionary<TTypeKey, TPropertyKey> d) : base(d) { }
        // TODO: Add more constructors if necessary
    }
}
