
using System.Collections.Generic;
using Image = System.Drawing.Image;

namespace ImageAutoTurner
{
    public interface IAutoRotate
    {
        void AutorotateImages(List<Image> images);
        void AutorotateImage(Image image);
    }
}
