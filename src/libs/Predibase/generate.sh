#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no single public spec covers both platform and inference APIs)

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Predibase has a partial spec for LoRAX inference only.
# openapi.yaml is manually maintained to cover both platform management and inference APIs.
autosdk generate openapi.yaml \
  --namespace Predibase \
  --clientClassName PredibaseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
