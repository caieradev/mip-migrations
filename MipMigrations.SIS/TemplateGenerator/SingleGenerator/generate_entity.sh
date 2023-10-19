#!/bin/bash

if [ $# -lt 1 ]
then
  echo "Usage: generate_mapping.sh <Index> <FuncionalityName>"
  exit 1
fi

index=$1
functionalityName=$2

./generate_file.sh "${functionalityName}" "../Templates/entity.txt" "${functionalityName}Entity.cs" "../../Domain/Application/Entities/${index}"