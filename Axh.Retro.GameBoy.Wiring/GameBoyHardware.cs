﻿using Axh.Retro.CPU.Common.Contracts.Memory;
using Axh.Retro.CPU.Z80.Contracts.Config;
using Axh.Retro.CPU.Z80.Contracts.Peripherals;
using Axh.Retro.CPU.Z80.Contracts.Registers;
using Axh.Retro.CPU.Z80.Contracts.State;
using Axh.Retro.CPU.Z80.Wiring;
using Axh.Retro.GameBoy.Config;
using Axh.Retro.GameBoy.Contracts.Devices;
using Axh.Retro.GameBoy.Contracts.Factories;
using Axh.Retro.GameBoy.Contracts.Graphics;
using Axh.Retro.GameBoy.Devices;
using Axh.Retro.GameBoy.Factories;
using Axh.Retro.GameBoy.Peripherals;
using Axh.Retro.GameBoy.Registers;
using Axh.Retro.GameBoy.Registers.Interfaces;
using DryIoc;

namespace Axh.Retro.GameBoy.Wiring
{
    public class GameBoyHardware : IZ80Module
    {
        /// <summary>
        /// Registers all hardware in this module.
        /// </summary>
        /// <param name="container">The container.</param>
        public void Register(IContainer container)
        {
            container.Register<IInterruptFlagsRegister, InterruptFlagsRegister>();
            container.Register<IHardwareRegisters, HardwareRegisters>();

            // Named registers
            container.Register<IInterruptEnableRegister, InterruptEnableRegister>();
            container.Register<IJoyPadRegister, JoyPad>();
            container.RegisterMany(new[] { typeof (ISerialPort), typeof (ISerialPortRegister) }, typeof (SyncSerialPort));
            container.Register<IMemoryBankController, MemoryBankController1>();

            // GPU registers.
            container.Register<IGpuRegisters, GpuRegisters>();
            container.Register<ILcdControlRegister, LcdControlRegister>();
            container.Register<ICurrentScanlineRegister, CurrentScanlineRegister>();
            container.Register<ILcdMonochromePaletteRegister, LcdMonochromePaletteRegister>();
            container.Register<ILcdStatusRegister, LcdStatusRegister>();

            // Un-named registers
            container.Register<IRegister, LazyDividerRegister>();
            container.Register<IRegister, LcdOamDmaTransferRegister>();

            // Peripherals, no IO mapped peripherals on GB, only memory mapped
            container.Register<IPeripheral, GameBoyMemoryMappedIO>();

            // GPU
            container.Register<IGpu, Gpu>();

            // Config.
            container.Register<IPlatformConfig, GameBoyPlatformConfig>(Reuse.Singleton);
            container.Register<IRuntimeConfig, GameBoyRuntimeConfig>(Reuse.Singleton);
            container.Register<ICartridgeFactory, CartridgeFactory>(Reuse.Singleton);

            // Initial state.
            var initialRegisterState =
                new Intel8080RegisterState(new GeneralPurposeRegisterState(0x00, 0x13, 0x00, 0xd8, 0x01, 0x4d),
                                           new AccumulatorAndFlagsRegisterState(0x01, 0xb0),
                                           0xfffe,
                                           0x0100,
                                           true,
                                           true,
                                           InterruptMode.InterruptMode0);
            container.RegisterInstance(initialRegisterState, Reuse.Singleton);
        }
    }
}