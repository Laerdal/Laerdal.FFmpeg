#!/bin/bash

nuget_project_name="Laerdal.Xamarin.FFmpeg"
nuget_output_folder="$nuget_project_name.Output"

usage(){
    echo "usage: ./build.sh [-p|--package [audio|full|full-gpl|https|https-gpl|min|min-gpl|video]] [-c|--clean-output] [-v|--verbose] [-o|--output path]"
    echo "parameters:"
    echo "  -p | --package [audio|full|full-gpl|https|https-gpl|min|min-gpl|video]    Multiple -p paramaters can be added. See https://github.com/tanersener/mobile-ffmpeg for more information"
    echo "  -c | --clean-output                                                       Cleans the output before building"
    echo "  -v | --verbose                                                            Enable verbose build details from msbuild tasks"
    echo "  -o | --output [path]                                                      Output path"
    echo "  -h | --help                                                               Prints this message"
    echo
}

while [ "$1" != "" ]; do
    case $1 in
        -p | --package )        shift
                                package_variants="${package_variants} $1"
                                ;;
        -o | --output )         shift
                                output_path=$1
                                ;;
        -c | --clean-output )   clean_output=1
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

if [ "$clean_output" = "1" ]; then
    echo ""
    echo "### CLEAN OUTPUT ###"
    echo ""

    rm -rf $nuget_output_folder
    echo "Deleted : $nuget_output_folder"
fi

if [ -z "$package_variants" ]; then
    package_variants="audio full full-gpl https https-gpl min min-gpl video"
fi

echo "package_variants : $package_variants"

for package_variant in $package_variants
do 
    . ./build.single.sh
done

if [ ! -z "$output_path" ]; then

    echo
    echo "### COPY FILES TO OUTPUT ###"
    echo

    mkdir -p $output_path
    cp -a $nuget_output_folder/. $output_path

    echo "Copied into $output_path"
fi