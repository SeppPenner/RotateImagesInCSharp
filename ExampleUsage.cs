using System.Drawing;

namespace ImageAutoTurner
{
    public class ExampleUsage
    {
        public void Test()
        {
            IAutoRotate rotator = new AutoRotate();
            rotator.AutorotateImage(new Bitmap("C:\\Users\\whatever\\Desktop\\abc.jpg"));
        } 
    }
}
