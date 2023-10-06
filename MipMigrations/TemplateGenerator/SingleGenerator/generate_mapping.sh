#!/bin/bash

if [ $# -lt 1 ]
then
  echo "Usage: generate_mapping.sh <FuncionalityName>"
  exit 1
fi

functionalityName=$1

./generate_file.sh "${functionalityName}" "../Templates/mapping.txt" "${functionalityName}Mapping.cs" "../../Infrastructure/Database/Mapping"