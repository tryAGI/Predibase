#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no single public spec covers both platform and inference APIs)
install_autosdk_cli

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
