RotateImagesInCSharp
===============

Kind of a 'library' for CSharp (.Net with WPF) on how to rotate images based on the 'orientation' EXIF tag.

[See here](https://msdn.microsoft.com/en-us/library/windows/desktop/ms534418(v=vs.85).aspx) for more information on the EXIF tags used in Windows (.Net).

For C# see also [here](https://github.com/SeppPenner/AutoImageTurner) for another possible implementation.

Example images using each of the EXIF orientation flags (1-to-8), in both landscape and portrait orientations [See here](https://github.com/recurser/exif-orientation-examples).

[See here](http://www.daveperrett.com/articles/2012/07/28/exif-orientation-handling-is-a-ghetto/) for more information.

## Basic usage:
```csharp
public void Test()
{
    IAutoRotate rotator = new AutoRotate();
    rotator.AutorotateImage(new Bitmap("C:\\Users\\whatever\\Desktop\\abc.jpg"));
} 
```
    
Change history
--------------

* **Version 1.0.0 (2016-12-03)** : Added basic usage to Readme.
* **Version 1.0.0 (2016-08-12)** : 1.0 release.

Copyright (of the images)
-------------------------

Dave Perrett :: hello@daveperrett.com :: [@daveperrett](http://twitter.com/daveperrett)

These images are licensed under the [MIT License](http://opensource.org/licenses/MIT).

Copyright (c) 2010 Dave Perrett. See [License](https://github.com/recurser/exif-orientation-examples/blob/master/LICENSE) for details.
