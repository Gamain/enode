﻿using System;

namespace ENode.Domain
{
    /// <summary>Represents a repository of the building block of Eric Evans's DDD.
    /// </summary>
    public interface IRepository
    {
        /// <summary>Get an aggregate from memory cache, if not exist, get it from event store.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="aggregateRootId"></param>
        /// <returns></returns>
        T Get<T>(object aggregateRootId) where T : class, IAggregateRoot;
        /// <summary>Get an aggregate from memory cache, if not exist, get it from event store.
        /// </summary>
        /// <param name="aggregateRootType"></param>
        /// <param name="aggregateRootId"></param>
        /// <returns></returns>
        IAggregateRoot Get(Type aggregateRootType, object aggregateRootId);
    }
}
