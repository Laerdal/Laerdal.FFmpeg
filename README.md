# Laerdal.FFmpeg

> Xamarin.iOS package : <https://github.com/Laerdal/Laerdal.FFmpeg.iOS>
>
> Xamarin.Android package : <https://github.com/Laerdal/Laerdal.FFmpeg.Android>

Xamarin binding library around @tanersener's Mobile-FFmpeg library.

The native Android and iOS libraries can be found here: <https://github.com/tanersener/mobile-ffmpeg>

| Mobile FFmpeg Package | Laerdal.FFmpeg |
|     :----    |     :----:    |
| Audio | [![NuGet Badge](https://buildstats.info/nuget/Laerdal.FFmpeg.Audio)](https://www.nuget.org/packages/Laerdal.FFmpeg.Audio/) |
| Full | [![NuGet Badge](https://buildstats.info/nuget/Laerdal.FFmpeg.Full)](https://www.nuget.org/packages/Laerdal.FFmpeg.Full/) |
| Full.Gpl | [![NuGet Badge](https://buildstats.info/nuget/Laerdal.FFmpeg.Full.Gpl)](https://www.nuget.org/packages/Laerdal.FFmpeg.Full.Gpl/) |
| Https | [![NuGet Badge](https://buildstats.info/nuget/Laerdal.FFmpeg.Https)](https://www.nuget.org/packages/Laerdal.FFmpeg.Https/) |
| Https.Gpl | [![NuGet Badge](https://buildstats.info/nuget/Laerdal.FFmpeg.Https.Gpl)](https://www.nuget.org/packages/Laerdal.FFmpeg.Https.Gpl/) |
| Min | [![NuGet Badge](https://buildstats.info/nuget/Laerdal.FFmpeg.Min)](https://www.nuget.org/packages/Laerdal.FFmpeg.Min/) |
| Min.Gpl | [![NuGet Badge](https://buildstats.info/nuget/Laerdal.FFmpeg.Min.Gpl)](https://www.nuget.org/packages/Laerdal.FFmpeg.Min.Gpl/) |
| Video | [![NuGet Badge](https://buildstats.info/nuget/Laerdal.FFmpeg.Video)](https://www.nuget.org/packages/Laerdal.FFmpeg.Video/) |

## External libraries

| Package | External libraries |
|     :----    | :----: |
| Audio | lame libilbc libvorbis opencore-amr opus shine soxr speex twolame vo-amrwbenc wavpack |
| Full | fontconfig freetype fribidi gmp gnutls kvazaar lame libaom libass libiconv libilbc libtheora libvorbis libvpx libxml2 opencore-amr opus shine snappy soxr speex twolame vo-amrwbenc wavpack |
| Full.Gpl | fontconfig freetype fribidi gmp gnutls kvazaar lame libaom libass libiconv libilbc libtheora libvorbis libvpx libxml2 opencore-amr opus shine snappy soxr speex twolame vid.stab vo-amrwbenc wavpack x264 x265 xvidcore |
| Https | gmp gnutls |
| Https.Gpl | gmp gnutls vid.stab x264 x265 xvidcore |
| Min | - |
| Min.Gpl | vid.stab x264 x265 xvidcore |
| Video | fontconfig freetype fribidi kvazaar libaom libass libiconv libtheora libvpx snappy |

> **Known limitation:**
> Due to issue with webp.framework on Xamarin iOS on linking stage we temporary removed it from usage

## How to use

Simply add the Nuget package you want into **ALL** of your Xamarin projects (Shared, iOS and Android). On iOS it will depend on the iOS package and on iOS it will depend on the Android package.

> **Known issue:**
>
> For iOS build, when linking you might get the following error :
>
> `Can't register the class when the dynamic registrar has been linked away.`
>
> To fix it you can either :
>
> - Switch to `<MtouchLink>SdkOnly</MtouchLink>` or `<MtouchLink>None</MtouchLink>`
> - Add `<MtouchExtraArgs>--optimize=-remove-dynamic-registrar</MtouchExtraArgs>` to the .csproj of your iOS project
>
> PS. If you know how I could fix it please PR or send a message :)

## Folder structure

- Laerdal.FFmpeg = Xamarin Nuget Library project and nuget files
- Laerdal.FFmpeg.Output = Build output from building *Laerdal.FFmpeg*

## Local build

### Steps to build

#### 1) Checkout

```bash
git clone https://github.com/Laerdal/Laerdal.FFmpeg.git
```

#### 2) Run build script

Usage:

```bash
./build.sh [-p|--package [audio|full|full-gpl|https|https-gpl|min|min-gpl|video]] [-r|--revision build_revision] [-c|--clean-output] [-v|--verbose]
```

Parameters:

- -p | --package [audio|full|full-gpl|https|https-gpl|min|min-gpl|video]
  - Multiple -p paramaters can be added.
  - Everything will be built if no -p parameter is used.
  - See <https://github.com/tanersener/mobile-ffmpeg> for more information
- -r | --revision [build_revision]
  - Sets the revision number, default = mdd.hMMSS
- -c | --clean-output
  - Cleans the output before building
- -v | --verbose
  - Enable verbose build details from msbuild tasks
- -h | --help
  - Prints this message

To build only full and full-gpl, clean the output and run objective sharpie to update the ApiDefinitions :

```bash
./build.sh -p full -p full-gpl -c -s
```

To build everything :

```bash
./build.sh
```
