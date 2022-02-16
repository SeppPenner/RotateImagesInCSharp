// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoRotate.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   A class to auto rotate images.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RotateImagesInCSharp;

/// <inheritdoc cref="IAutoRotate"/>
/// <summary>
/// A class to auto rotate images.
/// </summary>
/// <seealso cref="IAutoRotate"/>
public class AutoRotate : IAutoRotate
{
    /// <inheritdoc cref="IAutoRotate"/>
    /// <summary>
    /// Auto rotates a <see cref="List{T}"/> of images.
    /// </summary>
    /// <param name="images">The images.</param>
    /// <seealso cref="IAutoRotate"/>
    public void AutorotateImages(List<Image> images)
    {
        foreach (var image in images)
        {
            this.AutorotateImage(image);
        }
    }

    /// <inheritdoc cref="IAutoRotate"/>
    /// <summary>
    /// Auto rotates a image.
    /// </summary>
    /// <param name="image">The image.</param>
    /// <seealso cref="IAutoRotate"/>
    public void AutorotateImage(Image image)
    {
        if (Array.IndexOf(image.PropertyIdList, 274) <= -1)
        {
            return;
        }

        var value = image.GetPropertyItem(274)?.Value;

        if (value != null)
        {
            var orientation = value[0];
            SwitchImageRotation(image, orientation);
        }

        // EXIF data is now invalid and should be removed
        image.RemovePropertyItem(274);
    }

    /// <summary>
    /// Switches the image rotation.
    /// </summary>
    /// <param name="image">The image.</param>
    /// <param name="orientation">The orientation.</param>
    private static void SwitchImageRotation(Image image, int orientation)
    {
        switch (orientation)
        {
            case 1:
                // No rotation required.
                break;
            case 2:
                image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                break;
            case 3:
                image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                break;
            case 4:
                image.RotateFlip(RotateFlipType.Rotate180FlipX);
                break;
            case 5:
                image.RotateFlip(RotateFlipType.Rotate90FlipX);
                break;
            case 6:
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                break;
            case 7:
                image.RotateFlip(RotateFlipType.Rotate270FlipX);
                break;
            case 8:
                image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                break;
        }
    }
}
