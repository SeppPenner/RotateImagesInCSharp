// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAutoRotate.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   An interface to auto rotate images.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RotateImagesInCSharp;

/// <summary>
/// An interface to auto rotate images.
/// </summary>
public interface IAutoRotate
{
    /// <summary>
    /// Auto rotates a <see cref="List{T}"/> of images.
    /// </summary>
    /// <param name="images">The images.</param>
    void AutorotateImages(List<Image> images);

    /// <summary>
    /// Auto rotates a image.
    /// </summary>
    /// <param name="image">The image.</param>
    void AutorotateImage(Image image);
}
