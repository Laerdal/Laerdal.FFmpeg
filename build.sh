#!/bin/bash

# GITHUB INFORMATION
github_repo_owner=tanersener
github_repo=mobile-ffmpeg
github_release_id=28895129
github_info_file="$github_repo_owner.$github_repo.$github_release_id.info.json"

if [ ! -f "$github_info_file" ]; then
    echo ""
    echo "### DOWNLOADING GITHUB INFORMATION ###"
    echo ""
    github_info_file_url=https://api.github.com/repos/$github_repo_owner/$github_repo/releases/$github_release_id
    echo "Downloading $github_info_file_url to $github_info_file"
    curl -s $github_info_file_url > $github_info_file
fi

usage(){
    echo "### Wrong parameters ###"
    echo "usage: ./build.sh [-r build_revision]"
}

build_revision=`date +%m%d.%H%M%S`

while [ "$1" != "" ]; do
    case $1 in
        -r | --revision )       shift
                                build_revision=$1
                                ;;
        -h | --help )           usage
                                exit
                                ;;
        * )                     usage
                                exit 1
    esac
    shift
done

# Set version
github_tag_name=`cat $github_info_file | grep '"tag_name":' | sed -E 's/.*"([^"]+)".*/\1/' | sed 's/v//'`
github_short_version=`echo "$github_tag_name" | sed 's/.LTS//'`
build_version=$github_short_version.$build_revision
echo "##vso[build.updatebuildnumber]$build_version"
if [ -z "$github_short_version" ]; then
    echo "Failed : Could not read Version"
    cat $github_info_file
    exit 1
fi

nuget_project_folder="Laerdal.Xamarin.FFmpeg"
nuget_project_csproj="$nuget_project_folder/Laerdal.Xamarin.FFmpeg.csproj"
nuget_output_folder="$nuget_project_folder.Output"

build_package()
{
    nuget_package_variant_name=$1
    external_libraries=$2

    output_file="$nuget_output_folder/$nuget_project_folder.$nuget_package_variant_name.$build_version.nupkg"

    if [ -f "$output_file" ]; then
        echo "# '$output_file' already exists. Not building"
    else
        echo "# Building '$output_file'"
        msbuild $nuget_project_csproj -t:Rebuild -restore:True -p:Configuration=Release -p:NugetPackageVariantName=$nuget_package_variant_name -p:PackageVersion=$build_version -p:ExternalLibraries="$external_libraries"
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