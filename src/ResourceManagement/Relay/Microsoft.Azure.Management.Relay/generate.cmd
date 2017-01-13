::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
set autoRestVersion=1.0.0-Nightly20161215
if  "%1" == "" (
    set specFile="d:\SwaggerWork\v-ajnava_Fork\azure-rest-api-specs\arm-relay\2016-07-01\relay.json"
) else (
    set specFile="%1"
)
set repoRoot=%~dp0..\..\..\..
set generateFolder=%~dp0Generated

if exist %generateFolder% rd /S /Q  %generateFolder%
call "%repoRoot%\tools\autorest.gen.cmd" %specFile% Microsoft.Azure.Management.Relay %autoRestVersion% %generateFolder% "MICROSOFT_MIT" "-FT 2"
