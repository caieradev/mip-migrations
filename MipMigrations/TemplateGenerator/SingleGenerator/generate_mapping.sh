#!/bin/bash

if [ $# -lt 1 ]
then
  echo "Usage: generate_mapping.sh <Index> <FuncionalityName>"
  exit 1
fi

index=$1
functionalityName=$2

./generate_mapping_file.sh "${index}" "${functionalityName}" "../Templates/mapping.txt" "${functionalityName}Mapping.cs" "../../Infrastructure/Database/Mapping/${index}"