﻿namespace Axh.Retro.CPU.Z80.Contracts.OpCodes
{
    /// <summary>
    /// Primary Z80 op codes.
    /// </summary>
    public enum PrimaryOpCode : byte
    {
        NOP = 0x00,
        HALT = 0x76,

        // Prefixes
        Prefix_CB = 0xCB,
        Prefix_DD = 0xDD,
        Prefix_ED = 0xED,
        Prefix_FD = 0xFD,

        // 8 Bit Load
        LD_A_A = 0x7F,
        LD_B_A = 0x47,
        LD_C_A = 0x4F,
        LD_D_A = 0x57,
        LD_E_A = 0x5F,
        LD_H_A = 0x67,
        LD_L_A = 0x6F,
        LD_A_B = 0x78,
        LD_B_B = 0x40,
        LD_C_B = 0x48,
        LD_D_B = 0x50,
        LD_E_B = 0x58,
        LD_H_B = 0x60,
        LD_L_B = 0x68,
        LD_A_C = 0x79,
        LD_B_C = 0x41,
        LD_C_C = 0x49,
        LD_D_C = 0x51,
        LD_E_C = 0x59,
        LD_H_C = 0x61,
        LD_L_C = 0x69,
        LD_A_D = 0x7A,
        LD_B_D = 0x42,
        LD_C_D = 0x4A,
        LD_D_D = 0x52,
        LD_E_D = 0x5A,
        LD_H_D = 0x62,
        LD_L_D = 0x6A,
        LD_A_E = 0x7B,
        LD_B_E = 0x43,
        LD_C_E = 0x4B,
        LD_D_E = 0x53,
        LD_E_E = 0x5B,
        LD_H_E = 0x63,
        LD_L_E = 0x6B,
        LD_A_H = 0x7C,
        LD_B_H = 0x44,
        LD_C_H = 0x4C,
        LD_D_H = 0x54,
        LD_E_H = 0x5C,
        LD_H_H = 0x64,
        LD_L_H = 0x6C,
        LD_A_L = 0x7D,
        LD_B_L = 0x45,
        LD_C_L = 0x4D,
        LD_D_L = 0x55,
        LD_E_L = 0x5D,
        LD_H_L = 0x65,
        LD_L_L = 0x6D,

        LD_A_n = 0x3E,
        LD_B_n = 0x06,
        LD_C_n = 0x0E,
        LD_D_n = 0x16,
        LD_E_n = 0x1E,
        LD_H_n = 0x26,
        LD_L_n = 0x2E,

        LD_A_mHL = 0x7E,
        LD_B_mHL = 0x46,
        LD_C_mHL = 0x4E,
        LD_D_mHL = 0x56,
        LD_E_mHL = 0x5E,
        LD_H_mHL = 0x66,
        LD_L_mHL = 0x6E,

        LD_mHL_A = 0x77,
        LD_mHL_B = 0x70,
        LD_mHL_C = 0x71,
        LD_mHL_D = 0x72,
        LD_mHL_E = 0x73,
        LD_mHL_H = 0x74,
        LD_mHL_L = 0x75,

        LD_mHL_n = 0x36,

        LD_A_mBC = 0x0A,

        LD_A_mDE = 0x1A,

        LD_A_mnn = 0x3A,

        LD_mBC_A = 0x02,

        LD_mDE_A = 0x12,

        LD_mnn_A = 0x32,

        // 16 Bit Load
        LD_BC_nn = 0x01,
        LD_DE_nn = 0x11,
        LD_HL_nn = 0x21,
        LD_SP_nn = 0x31,

        LD_HL_mnn = 0x2A,

        LD_mnn_HL = 0x22,

        LD_SP_HL = 0xF9,

        PUSH_BC = 0xC5,
        PUSH_DE = 0xD5,
        PUSH_HL = 0xE5,
        PUSH_AF = 0xF5,

        POP_BC = 0xC1,
        POP_DE = 0xD1,
        POP_HL = 0xE1,
        POP_AF = 0xF1,

        // 8 Bit Arithmetic
        ADD_A_A = 0x87,
        ADD_A_B = 0x80,
        ADD_A_C = 0x81,
        ADD_A_D = 0x82,
        ADD_A_E = 0x83,
        ADD_A_H = 0x84,
        ADD_A_L = 0x85,
        ADD_A_n = 0xC6,
        ADD_A_mHL = 0x86,
        ADC_A_A = 0x8F,
        ADC_A_B = 0x88,
        ADC_A_C = 0x89,
        ADC_A_D = 0x8A,
        ADC_A_E = 0x8B,
        ADC_A_H = 0x8C,
        ADC_A_L = 0x8D,
        ADC_A_n = 0xCE,
        ADC_A_mHL = 0x8E,
        SUB_A_A = 0x97,
        SUB_A_B = 0x90,
        SUB_A_C = 0x91,
        SUB_A_D = 0x92,
        SUB_A_E = 0x93,
        SUB_A_H = 0x94,
        SUB_A_L = 0x95,
        SUB_A_n = 0xD6,
        SUB_A_mHL = 0x96,
        SBC_A_A = 0x9F,
        SBC_A_B = 0x98,
        SBC_A_C = 0x99,
        SBC_A_D = 0x9A,
        SBC_A_E = 0x9B,
        SBC_A_H = 0x9C,
        SBC_A_L = 0x9D,
        SBC_A_n = 0xDE,
        SBC_A_mHL = 0x9E,
        AND_A = 0xA7,
        AND_B = 0xA0,
        AND_C = 0xA1,
        AND_D = 0xA2,
        AND_E = 0xA3,
        AND_H = 0xA4,
        AND_L = 0xA5,
        AND_n = 0xE6,
        AND_mHL = 0xA6,
        OR_A = 0xB7,
        OR_B = 0xB0,
        OR_C = 0xB1,
        OR_D = 0xB2,
        OR_E = 0xB3,
        OR_H = 0xB4,
        OR_L = 0xB5,
        OR_n = 0xF6,
        OR_mHL = 0xB6,
        XOR_A = 0xAF,
        XOR_B = 0xA8,
        XOR_C = 0xA9,
        XOR_D = 0xAA,
        XOR_E = 0xAB,
        XOR_H = 0xAC,
        XOR_L = 0xAD,
        XOR_n = 0xEE,
        XOR_mHL = 0xAE,
        CP_A = 0xBF,
        CP_B = 0xB8,
        CP_C = 0xB9,
        CP_D = 0xBA,
        CP_E = 0xBB,
        CP_H = 0xBC,
        CP_L = 0xBD,
        CP_n = 0xFE,
        CP_mHL = 0xBE,
        INC_A = 0x3C,
        INC_B = 0x04,
        INC_C = 0x0C,
        INC_D = 0x14,
        INC_E = 0x1C,
        INC_H = 0x24,
        INC_L = 0x2C,
        INC_mHL = 0x34,
        DEC_A = 0x3D,
        DEC_B = 0x05,
        DEC_C = 0x0D,
        DEC_D = 0x15,
        DEC_E = 0x1D,
        DEC_H = 0x25,
        DEC_L = 0x2D,
        DEC_mHL = 0x35,

        // 16 Bit Arithmetic
        ADD_HL_BC = 0x09,
        ADD_HL_DE = 0x19,
        ADD_HL_HL = 0x29,
        ADD_HL_SP = 0x39,

        INC_BC = 0x03,
        INC_DE = 0x13,
        INC_HL = 0x23,
        INC_SP = 0x33,

        DEC_BC = 0x0B,
        DEC_DE = 0x1B,
        DEC_HL = 0x2B,
        DEC_SP = 0x3B,

        // Exchange, block transfer and search
        EX_DE_HL = 0xEB,
        EX_AF = 0x08,
        EXX = 0xD9,
        EX_mSP_HL = 0xE3,

        // General purpose arithmetic and CPU control
        DAA = 0x27,
        CPL = 0x2F,
        CCF = 0x3F,
        SCF = 0x37,
        DI = 0xF3,
        EI = 0xFB,

        // Rotate and Shift
        RLCA = 0x07,
        RLA = 0x17,
        RRCA = 0x0f,
        RRA = 0x1f,

        // Jump
        JP = 0xC3,
        JP_NZ = 0xC2,
        JP_Z = 0xCA,
        JP_NC = 0xD2,
        JP_C = 0xDA,
        JP_PO = 0xE2,
        JP_PE = 0xEA,
        JP_P = 0xF2,
        JP_M = 0xFA,
        JR = 0x18,
        JR_C = 0x38,
        JR_NC = 0x30,
        JR_Z = 0x28,
        JR_NZ = 0x20,
        JP_mHL = 0xE9,
        DJNZ = 0x10,

        // Call
        CALL = 0xCD,
        CALL_NZ = 0xC4,
        CALL_Z = 0xCC,
        CALL_NC = 0xD4,
        CALL_C = 0xDC,
        CALL_PO = 0xE4,
        CALL_PE = 0xEC,
        CALL_P = 0xF4,
        CALL_M = 0xFC,

        // Return
        RET = 0xC9,
        RET_NZ = 0xC0,
        RET_Z = 0xC8,
        RET_NC = 0xD0,
        RET_C = 0xD8,
        RET_PO = 0xE0,
        RET_PE = 0xE8,
        RET_P = 0xF0,
        RET_M = 0xF8,

        // Reset
        RST_00 = 0xC7,
        RST_08 = 0xCF,
        RST_10 = 0xD7,
        RST_18 = 0xDF,
        RST_20 = 0xE7,
        RST_28 = 0xEF,
        RST_30 = 0xF7,
        RST_38 = 0xFF,

        // IO
        IN_A_n = 0xDB,
        OUT_A_n = 0xD3
    }
}