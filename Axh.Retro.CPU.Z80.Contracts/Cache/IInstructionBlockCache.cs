﻿namespace Axh.Retro.CPU.Z80.Contracts.Cache
{
    using System;

    using Axh.Retro.CPU.Z80.Contracts.Core;
    using Axh.Retro.CPU.Z80.Contracts.Registers;

    /// <summary>
    /// Doesn't need to be thread safe
    /// </summary>
    /// <typeparam name="TRegisters"></typeparam>
    public interface IInstructionBlockCache<TRegisters> where TRegisters : IRegisters
    {
        /// <summary>
        /// Get an instruction block from the cache at address. If not present then call getInstanceFunc and add to the cache.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="getInstanceFunc"></param>
        /// <returns></returns>
        IInstructionBlock<TRegisters> GetOrSet(ushort address, Func<IInstructionBlock<TRegisters>> getInstanceFunc);

        /// <summary>
        /// Invalidates all cache from address for length
        /// </summary>
        /// <param name="address"></param>
        /// <param name="length"></param>
        void InvalidateCache(ushort address, ushort length);
    }
}
