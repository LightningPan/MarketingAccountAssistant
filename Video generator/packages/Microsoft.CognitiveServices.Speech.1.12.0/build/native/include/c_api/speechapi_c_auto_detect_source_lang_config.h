//
// Copyright (c) Microsoft. All rights reserved.
// See https://aka.ms/csspeech/license201809 for the full license information.
//

#pragma once
#include <speechapi_c_common.h>

SPXAPI create_auto_detect_source_lang_config_from_languages(SPXAUTODETECTSOURCELANGCONFIGHANDLE* hAutoDetectSourceLanguageconfig, const char* languages);
SPXAPI create_auto_detect_source_lang_config_from_source_lang_config(SPXAUTODETECTSOURCELANGCONFIGHANDLE* hAutoDetectSourceLanguageconfig, SPXSOURCELANGCONFIGHANDLE hSourceLanguageConfig);
SPXAPI add_source_lang_config_to_auto_detect_source_lang_config(SPXAUTODETECTSOURCELANGCONFIGHANDLE hAutoDetectSourceLanguageconfig, SPXSOURCELANGCONFIGHANDLE hSourceLanguageConfig);
SPXAPI_(bool) auto_detect_source_lang_config_is_handle_valid(SPXAUTODETECTSOURCELANGCONFIGHANDLE hAutoDetectSourceLanguageconfig);
SPXAPI auto_detect_source_lang_config_release(SPXAUTODETECTSOURCELANGCONFIGHANDLE hAutoDetectSourceLanguageconfig);
SPXAPI auto_detect_source_lang_config_get_property_bag(SPXAUTODETECTSOURCELANGCONFIGHANDLE hAutoDetectSourceLanguageconfig, SPXPROPERTYBAGHANDLE* hpropbag);
