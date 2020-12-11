#!/bin/bash

repo=tanersener/mobile-ffmpeg
url=`curl -fs -o/dev/null -w %{redirect_url} https://github.com/$repo/releases/latest`
echo "url = $url"
base_version=`basename $url | sed 's/v//'`
echo "base_version = $base_version"
version="$base_version.0"
echo "version = $version"

nuget_project_folder="Laerdal.Xamarin.FFmpeg"
nuget_project_csproj="$nuget_project_folder/Laerdal.Xamarin.FFmpeg.csproj"
nuget_output_folder="$nuget_project_folder.Output"

build_package()
{
    nuget_package_variant_name=$1
    external_libraries=$2

    output_file="$nuget_output_folder/$nuget_project_folder.$nuget_package_variant_name.$version.nupkg"

    if [ -f "$output_file" ]; then
        echo "# '$output_file' already exists. Not building"
    else
        echo "# Building '$output_file'"
        msbuild $nuget_project_csproj -t:Rebuild -restore:True -p:Configuration=Release -p:NugetPackageVariantName=$nuget_package_variant_name -p:PackageVersion=$version -p:ExternalLibraries="$external_libraries"
    fi
}
# see https://github.com/tanersener/mobile-ffmpeg for more information
time build_package Audio "lame libilbc libvorbis opencore-amr opus shine soxr speex twolame vo-amrwbenc wavpack"
time build_package Full "fontconfig freetype fribidi gmp gnutls kvazaar lame libaom libass libiconv libilbc libtheora libvorbis libvpx libwebp libxml2 opencore-amr opus shine snappy soxr speex twolame vo-amrwbenc wavpack"
time build_package Full.Gpl "fontconfig freetype fribidi gmp gnutls kvazaar lame libaom libass libiconv libilbc libtheora libvorbis libvpx libwebp libxml2 opencore-amr opus shine snappy soxr speex twolame vid.stab vo-amrwbenc wavpack x264 x265 xvidcore"
time build_package Https "gmp gnutls"
time build_package Https.Gpl "gmp gnutls vid.stab x264 x265 xvidcore"
time build_package Min "-"
time build_package Min.Gpl "vid.stab x264 x265 xvidcore"
time build_package Video "fontconfig freetype fribidi kvazaar libaom libass libiconv libtheora libvpx libwebp snappy"