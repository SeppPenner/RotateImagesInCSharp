RotateImagesInCSharp
===============

Kind of a 'library' for CSharp (.Net with WPF) on how to rotate images based on the 'orientation' EXIF tag.

[![GitHub issues](https://img.shields.io/github/issues/SeppPenner/RotateImagesInCSharp.svg)](https://github.com/SeppPenner/RotateImagesInCSharp/issues)
[![GitHub forks](https://img.shields.io/github/forks/SeppPenner/RotateImagesInCSharp.svg)](https://github.com/SeppPenner/RotateImagesInCSharp/network)
[![GitHub stars](https://img.shields.io/github/stars/SeppPenner/RotateImagesInCSharp.svg)](https://github.com/SeppPenner/RotateImagesInCSharp/stargazers)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://raw.githubusercontent.com/SeppPenner/RotateImagesInCSharp/master/License.txt)
[![Known Vulnerabilities](https://snyk.io/test/github/SeppPenner/RotateImagesInCSharp/badge.svg)](https://snyk.io/test/github/SeppPenner/RotateImagesInCSharp)

[See here](https://msdn.microsoft.com/en-us/library/windows/desktop/ms534418(v=vs.85).aspx) for more information on the EXIF tags used in Windows (.Net).

For C# see also [here](https://github.com/SeppPenner/AutoImageTurner) for another possible implementation.

Example images using each of the EXIF orientation flags (1-to-8), in both landscape and portrait orientations [See here](https://github.com/recurser/exif-orientation-examples).

[See here](http://www.daveperrett.com/articles/2012/07/28/exif-orientation-handling-is-a-ghetto/) for more information.

[![Build status](https://ci.appveyor.com/api/projects/status/c3qj32dh24qixots?svg=true)](https://ci.appveyor.com/project/SeppPenner/rotateimagesincsharp)

## Basic usage
```csharp
public void Test()
{
    IAutoRotate rotator = new AutoRotate();
    rotator.AutorotateImage(new Bitmap("C:\\Users\\whatever\\Desktop\\abc.jpg"));
} 
```

Copyright (of the images)
-------------------------

Dave Perrett :: hello@daveperrett.com :: [@daveperrett](http://twitter.com/daveperrett)

These images are licensed under the [MIT License](http://opensource.org/licenses/MIT).

Copyright (c) 2010 Dave Perrett. See [License](https://github.com/recurser/exif-orientation-examples/blob/master/LICENSE) for details.

Change history
--------------

See the [Changelog](https://github.com/SeppPenner/RotateImagesInCSharp/blob/master/Changelog.md).