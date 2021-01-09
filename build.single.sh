#!/bin/bash

usage(){
    echo "usage: ./build.single.sh [-p|--package [audio|full|full-gpl|https|https-gpl|min|min-gpl|video]] [-r|--revision build_revision] [-v|--verbose]"
    echo "parameters:"
    echo "  -p | --package [audio|full|full-gpl|https|https-gpl|min|min-gpl|video]    REQUIRED, See https://github.com/tanersener/mobile-ffmpeg for more information"
    echo "  -r | --revision [build_revision]                                          Sets the revision number, default = mdd.hMMSS"
    echo "  -v | --verbose                                                            Enable verbose build details from msbuild tasks"
    echo "  -h | --help                                                               Prints this message"
    echo
}

while [ "$1" != "" ]; do
    case $1 in
        -p | --package )        shift
                                package_variant=$1
                                ;;
        -r | --revision )       shift
                                build_revision=$1
                                ;;
        -v | --verbose )        verbose=1
                                ;;
        -h | --help )           usage
                                exit
                                ;;
        * )                     echo
                                echo "### Wrong parameter: $1 ###"
                                echo
                                usage
                                exit 1
    esac
    shift
done

# Required variables
if [ -z "$package_variant" ]; then
    usage
    exit 1
fi

if [ -z "$build_revision" ]; then
    build_revision=`date +%-m%d.%-H%M%S`
fi

# find the latest ID here : https://api.github.com/repos/tanersener/mobile-ffmpeg/releases/latest
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

echo ""
echo "### INFORMATION ###"
echo ""

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

# Static configuration
nuget_project_folder="Laerdal.Xamarin.FFmpeg"
nuget_project_name="Laerdal.Xamarin.FFmpeg"
nuget_output_folder="$nuget_project_name.Output"
nuget_csproj_path="$nuget_project_folder/$nuget_project_name.csproj"

# see https://github.com/tanersener/mobile-ffmpeg for more information
package_libraries="?"
[ "$package_variant" = "audio" ] && package_libraries="lame libilbc libvorbis opencore-amr opus shine soxr speex twolame vo-amrwbenc wavpack"
[ "$package_variant" = "full" ] && package_libraries="fontconfig freetype fribidi gmp gnutls kvazaar lame libaom libass libiconv libilbc libtheora libvorbis libvpx libwebp libxml2 opencore-amr opus shine snappy soxr speex twolame vo-amrwbenc wavpack"
[ "$package_variant" = "full-gpl" ] && package_libraries="fontconfig freetype fribidi gmp gnutls kvazaar lame libaom libass libiconv libilbc libtheora libvorbis libvpx libwebp libxml2 opencore-amr opus shine snappy soxr speex twolame vid.stab vo-amrwbenc wavpack x264 x265 xvidcore"
[ "$package_variant" = "https" ] && package_libraries="gmp gnutls"
[ "$package_variant" = "https-gpl" ] && package_libraries="gmp gnutls vid.stab x264 x265 xvidcore"
[ "$package_variant" = "min" ] && package_libraries="-"
[ "$package_variant" = "min-gpl" ] && package_libraries="vid.stab x264 x265 xvidcore"
[ "$package_variant" = "video" ] && package_libraries="fontconfig freetype fribidi kvazaar libaom libass libiconv libtheora libvpx libwebp snappy"

nuget_variant="$package_variant"
[ "$package_variant" = "audio" ] && nuget_variant="Audio"
[ "$package_variant" = "full" ] && nuget_variant="Full"
[ "$package_variant" = "full-gpl" ] && nuget_variant="Full.Gpl"
[ "$package_variant" = "https" ] && nuget_variant="Https"
[ "$package_variant" = "https-gpl" ] && nuget_variant="Https.Gpl"
[ "$package_variant" = "min" ] && nuget_variant="Min"
[ "$package_variant" = "min-gpl" ] && nuget_variant="Min.Gpl"
[ "$package_variant" = "video" ] && nuget_variant="Video"

nuget_filename="$nuget_project_name.$nuget_variant.$build_version.nupkg"
nuget_output_file="$nuget_output_folder/$nuget_filename"

# Generates variables
echo "build_version = $build_version"
echo ""
echo "github_repo_owner = $github_repo_owner"
echo "github_repo = $github_repo"
echo "github_release_id = $github_release_id"
echo "github_info_file = $github_info_file"
echo "github_tag_name = $github_tag_name"
echo "github_short_version = $github_short_version"
echo ""
echo "package_variant = $package_variant"
echo "package_libraries = $package_libraries"
echo ""
echo "nuget_variant = $nuget_variant"
echo "nuget_project_folder = $nuget_project_folder"
echo "nuget_output_folder = $nuget_output_folder"
echo "nuget_project_name = $nuget_project_name"
echo "nuget_csproj_path = $nuget_csproj_path"
echo "nuget_filename = $nuget_filename"

echo ""
echo "### FIND NUGET VERSIONS ###"
echo ""

nuget_server_packages=`nuget list Laerdal.Xamarin.FFmpeg`
nuget_version_to_use_for_android=`echo "$nuget_server_packages" | grep "Laerdal.Xamarin.FFmpeg.Android.$nuget_variant " | tail -n 1 | sed "s/Laerdal.Xamarin.FFmpeg.Android.$nuget_variant //"`
nuget_version_to_use_for_ios=`echo "$nuget_server_packages" | grep "Laerdal.Xamarin.FFmpeg.iOS.$nuget_variant " | tail -n 1 | sed "s/Laerdal.Xamarin.FFmpeg.iOS.$nuget_variant //"`

echo "nuget_version_to_use_for_android = $nuget_version_to_use_for_android"
echo "nuget_version_to_use_for_ios = $nuget_version_to_use_for_ios"

echo ""
echo "### MSBUILD ###"
echo ""

msbuild_parameters=""
if [ ! "$verbose" = "1" ]; then
    msbuild_parameters="${msbuild_parameters} -nologo -verbosity:quiet"
fi
msbuild_parameters="${msbuild_parameters} -t:Rebuild"
msbuild_parameters="${msbuild_parameters} -restore:True"
msbuild_parameters="${msbuild_parameters} -p:Configuration=Release"
msbuild_parameters="${msbuild_parameters} -p:NugetPackageVariantName=$nuget_variant"
msbuild_parameters="${msbuild_parameters} -p:PackageVersion=$build_version"
msbuild_parameters="${msbuild_parameters} -p:ExternalLibraries=\"$package_libraries\""
msbuild_parameters="${msbuild_parameters} -p:iOSPackageVersion=$nuget_version_to_use_for_ios"
msbuild_parameters="${msbuild_parameters} -p:AndroidPackageVersion=$nuget_version_to_use_for_android"
echo "msbuild_parameters = $msbuild_parameters"
echo ""

rm -rf $nuget_project_folder/bin
rm -rf $nuget_project_folder/obj
msbuild $nuget_csproj_path $msbuild_parameters

if [ -f "$nuget_output_file" ]; then
    echo "Created :"
    echo "  - $nuget_output_file"
    echo ""
    rm -rf $nuget_frameworks_folder
else
    echo "Failed : Can't find '$nuget_output_file'"
    exit 1
fi