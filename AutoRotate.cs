using System;
using System.Collections.Generic;
using System.Drawing;
using Image = System.Drawing.Image;

namespace ImageAutoTurner
{
    public class AutoRotate: IAutoRotate
    {
        public void AutorotateImages(List<Image> images)
        {
            foreach (Image image in images)
            {
                AutorotateImage(image);
            }
        }

        public void AutorotateImage(Image image)
        {
            if (Array.IndexOf(image.PropertyIdList, 274) > -1)
            {
                int orientation = image.GetPropertyItem(274).Value[0];
                SwitchImageRotation(image, orientation);
                //EXIF data is now invalid and should be removed
                image.RemovePropertyItem(274);
            }
        }

        private void SwitchImageRotation(Image image, int orientation)
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
}