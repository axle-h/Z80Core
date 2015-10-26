﻿namespace Axh.Retro.CPU.X80.Contracts.OpCodes
{
    public enum PrefixCbOpCode : byte
    {
        // Rotate and Shift
        RLC_B = 0x00,
        RLC_C = 0x01,
        RLC_D = 0x02,
        RLC_E = 0x03,
        RLC_H = 0x04,
        RLC_L = 0x05,
        RLC_mHL = 0x06,
        RLC_A = 0x07,

        RL_B = 0x10,
        RL_C = 0x11,
        RL_D = 0x12,
        RL_E = 0x13,
        RL_H = 0x14,
        RL_L = 0x15,
        RL_mHL = 0x16,
        RL_A = 0x17,

        RRC_B = 0x08,
        RRC_C = 0x09,
        RRC_D = 0x0A,
        RRC_E = 0x0B,
        RRC_H = 0x0C,
        RRC_L = 0x0D,
        RRC_mHL = 0x0E,
        RRC_A = 0x0F,

        RR_B = 0x18,
        RR_C = 0x19,
        RR_D = 0x1A,
        RR_E = 0x1B,
        RR_H = 0x1C,
        RR_L = 0x1D,
        RR_mHL = 0x1E,
        RR_A = 0x1F,

        SLA_B = 0x20,
        SLA_C = 0x21,
        SLA_D = 0x22,
        SLA_E = 0x23,
        SLA_H = 0x24,
        SLA_L = 0x25,
        SLA_mHL = 0x26,
        SLA_A = 0x27,

        SRA_B = 0x28,
        SRA_C = 0x29,
        SRA_D = 0x2A,
        SRA_E = 0x2B,
        SRA_H = 0x2C,
        SRA_L = 0x2D,
        SRA_mHL = 0x2E,
        SRA_A = 0x2F,

        SRL_B = 0x38,
        SRL_C = 0x39,
        SRL_D = 0x3A,
        SRL_E = 0x3B,
        SRL_H = 0x3C,
        SRL_L = 0x3D,
        SRL_mHL = 0x3E,
        SRL_A = 0x3F,
    }
}
