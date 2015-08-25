﻿namespace Axh.Retro.CPU.X80.Contracts.Memory
{
    public interface IMmu
    {
        byte ReadByte(ushort address);
        ushort ReadWord(ushort address);
        byte[] ReadBytes(ushort address, int length);
        void WriteByte(ushort address, byte value);
        void WriteWord(ushort address, ushort word);
        void WriteBytes(ushort address, byte[] bytes);
    }
}