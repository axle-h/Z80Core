﻿namespace Axh.Retro.CPU.X80.Contracts.Peripherals
{
    using Axh.Retro.CPU.X80.Contracts.Memory;

    public interface IPeripheralManager
    {
        /// <summary>
        /// Read the next byte from the peripheral at IO port
        /// </summary>
        /// <param name="port">The port of the device to read from</param>
        /// <param name="addressMsb">The most significant byte of the address bus (the LSB is used as the IO port)</param>
        /// <returns></returns>
        byte ReadByteFromPort(byte port, byte addressMsb);

        /// <summary>
        /// Write a byte to the peripheral at IO port
        /// </summary>
        /// <param name="port">The port of the device to write to</param>
        /// <param name="addressMsb">The most significant byte of the address bus (the LSB is used as the IO port)</param>
        /// <param name="value">The byte to write</param>
        void WriteByteToPort(byte port, byte addressMsb, byte value);

        /// <summary>
        /// Halt all peripherals
        /// </summary>
        void Halt();

        /// <summary>
        /// Resume all peripherals
        /// </summary>
        void Resume();

        /// <summary>
        /// Register a peripheral with this peripheral manager
        /// </summary>
        /// <param name="peripheral"></param>
        void RegisterPeripheral(IPeripheral peripheral);

        /// <summary>
        /// Register the an mmu for use in dma peripherals
        /// </summary>
        /// <param name="mmu"></param>
        void RegisterMmuForDma(IMmu mmu);
    }
}