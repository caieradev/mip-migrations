#!/bin/bash

if [ $# -lt 3 ]
then
  echo "Usage: generate_file.sh <FuncionalityName> <template_file> <output_filename> [<outDir>]"
  exit 1
fi

# index
index=$1

# functionality name
name=$2

# template file
template_file=$3

if [ ! -f "$template_file" ]
then
  echo "Template file $template_file does not exist"
  exit 1
fi

output_filename=$4

# output directory (if not informed, use current directory)
if [ $# -ge 4 ]
then
  out_dir=$5
else
  out_dir=.
fi

# check if file already exists
output_file="${out_dir}/${output_filename}"
if [ -f "$output_file" ]
then
  echo "${output_filename} already exists on ${out_dir}"
  exit 1
fi

# replace template variable with functionality name
sed -e "s/{FUNCTIONALITY_NAME}/${name}/g" -e "s/{INDEX}/${index}/g" "${template_file}" > "${output_file}"

echo "Created ${output_file}"
