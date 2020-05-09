
# PixivSgsDownloader

应用以下载Pixiv上的三月精插画, 我也不知为什么写这个东西...  
若看见蹩脚机翻中文或夹杂英文, 请见谅, 本人中文水平有限

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

在自己的设备上编译与运行(懒得发release了)

首先需要下载源码

使用git:

```bash
git clone https://github.com/sangetsusei/PixivSgsDownloader.git
```
  
或者可以直接按右上方的`Clone or download`然后按`Download ZIP`
解压即可

### Installing

A step by step series of examples that tell you how to get a development env running

如果你没有.net core的开发环境, 需要在首先:  
[Install the .NET Core SDK](https://docs.microsoft.com/en-us/dotnet/core/install/sdk)

确保在项目的根目录下

```bash
dotnet restore
```

```bash
dotnet build
```

如果一切顺利:

```bash
$ dotnet run
> Usage: PixivSgsCli.exe [options]

  Options:

    -v | --version
    Show version information
```

将会显示类似这样的运行结果

使用`/bin/Debug/netcoreapp3.1/`下的编译完成的`PixivSgsCli.dll`
以
```bash
dotnet PixivSgsCli.dll [options] [parameters]
```
就可以用了

### Usage

等有时间了再写这个

## Built With

* [.NET core](https://dotnet.microsoft.com/) - The web framework used
* [CommandDotNet](https://maven.apache.org/) - Lib for command line apps
* [pixivcs](https://github.com/tobiichiamane/pixivcs) - Pixiv API implemented in C#

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* 三月精可爱
* 此项目不保证持续维护
* 只是暂时用的, 所以功能和操作比较局限, 之后也不会完善
