﻿namespace Axh.Retro.GameBoy.Contracts.Peripherals
{
    using System.Drawing;

    public interface IRenderHandler
    {
        /// <summary>
        /// Called every time the GB LCD is updated.
        /// Don't hang on to frame instances.
        /// 
        /// TODO: firm up whether we will be passing a new Bitmap instance each call to Paint, or providing a reference to the same instance...
        /// </summary>
        /// <param name="frame"></param>
        void Paint(Bitmap frame);
    }
}
