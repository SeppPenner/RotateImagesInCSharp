// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RotateImagesInCSharp
{
    using System.Drawing;

    /// <summary>
    /// The main program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
        public static void Main()
        {
            var rotate = new AutoRotate();
            rotate.AutorotateImage(new Bitmap("C:\\Users\\whatever\\Desktop\\abc.jpg"));
        } 
    }
}
