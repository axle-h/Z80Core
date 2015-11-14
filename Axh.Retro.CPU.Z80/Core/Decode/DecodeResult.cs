﻿namespace Axh.Retro.CPU.Z80.Core.Decode
{
    using System;

    internal class DecodeResult
    {
        public DecodeResult(Opcode opcode)
        {
            Opcode = opcode;
        }

        public DecodeResult(Opcode opcode, Operand operand1)
        {
            Opcode = opcode;
            Operand1 = operand1;
        }
        
        public DecodeResult(Opcode opcode, Operand operand1, Operand operand2)
        {
            Opcode = opcode;
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public DecodeResult WithFlag(FlagTest flagTest)
        {
            this.FlagTest = flagTest;
            return this;
        }

        public DecodeResult AddLiteral(byte literal)
        {
            this.ByteLiteral = literal;
            return this;
        }

        public DecodeResult WithByteLiteral()
        {
            this.OpCodeMeta |= OpCodeMeta.ByteLiteral;
            return this;
        }

        public DecodeResult AddLiteral(ushort literal)
        {
            this.WordLiteral = literal;
            return this;
        }

        public DecodeResult WithWordLiteral()
        {
            this.OpCodeMeta |= OpCodeMeta.WordLiteral;
            return this;
        }

        public DecodeResult AddDisplacement(byte displacement)
        {
            this.Displacement = (sbyte)displacement;
            return this;
        }

        public DecodeResult WithDisplacement()
        {
            this.OpCodeMeta |= OpCodeMeta.Displacement;
            return this;
        }

        public DecodeResult EndBlock()
        {
            this.OpCodeMeta |= OpCodeMeta.EndBlock;
            return this;
        }

        public void AutoCopy()
        {
            this.OpCodeMeta |= OpCodeMeta.AutoCopy;
        }
        
        public Opcode Opcode { get; }

        public Operand Operand1 { get; set; }

        public Operand Operand2 { get; set; }

        public FlagTest FlagTest { get; private set; }

        public byte ByteLiteral { get; private set; }

        public ushort WordLiteral { get; private set; }

        public sbyte Displacement { get; private set; }

        public OpCodeMeta OpCodeMeta { get; private set; }
    }

    [Flags]
    internal enum OpCodeMeta
    {
        None = 0,
        ByteLiteral,
        WordLiteral,
        Displacement,
        EndBlock,
        AutoCopy
    }
}