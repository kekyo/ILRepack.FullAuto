#!/bin/sh

# ILRepack - Full automatic ILRepack executor on .NET, .NET Core and .NET Framework
# Copyright (c) Kouji Matsui (@kozy_kekyo, @kekyo@mastodon.cloud)
#
# Licensed under MIT: https://opensource.org/licenses/MIT


echo ""
echo "==========================================================="
echo "Build ILRepack.FullAuto"
echo ""

# git clean -xfd

dotnet restore
dotnet pack -p:Configuration=Release -p:Platform=AnyCPU -o artifacts ILRepack.FullAuto/ILRepack.FullAuto.csproj
