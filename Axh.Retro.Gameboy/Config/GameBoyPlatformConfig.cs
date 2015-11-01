﻿namespace Axh.Retro.GameBoy.Config
{
    using System.Collections.Generic;

    using Axh.Retro.CPU.X80.Contracts;
    using Axh.Retro.CPU.X80.Contracts.Config;

    public class GameBoyPlatformConfig : IPlatformConfig
    {
        private const double CpuFrequency = 4.194304;
        private const ushort SystemMemoryBankLength = 0x0fff;
        private const ushort SystemMemoryBank0Address = 0xc000;
        private const ushort SystemMemoryBank1Address = 0xd000;

        public GameBoyPlatformConfig()
        {
            var systemMemoryBank0Config = new SimpleMemoryBankConfig(0, SystemMemoryBank0Address, SystemMemoryBankLength);
            var systemMemoryBank1Config = new SimpleMemoryBankConfig(1, SystemMemoryBank1Address, SystemMemoryBankLength);

            this.RandomAccessMemoryBanks = new[] { systemMemoryBank0Config, systemMemoryBank1Config };
        }

        public CpuMode CpuMode => CpuMode.GameBoy;

        public IEnumerable<IMemoryBankConfig> RandomAccessMemoryBanks { get; }

        public double? MachineCycleSpeedMhz => CpuFrequency;

        public double? ThrottlingStateSpeedMhz => CpuFrequency / 4;
    }
}
