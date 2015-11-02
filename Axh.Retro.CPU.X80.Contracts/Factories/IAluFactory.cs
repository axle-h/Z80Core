namespace Axh.Retro.CPU.X80.Contracts.Factories
{
    using Axh.Retro.CPU.X80.Contracts.Core;
    using Axh.Retro.CPU.X80.Contracts.Registers;

    public interface IAluFactory
    {
        IArithmeticLogicUnit GetArithmeticLogicUnit(IFlagsRegister flagsRegister);
    }
}