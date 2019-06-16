﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Amazon.Lambda.Core;
using AlexaTemplate.Helpers;
using AlexaTemplate.Interface;

namespace AlexaTemplate.Handlers.IntentHandlers
{
    class StopIntent : IRequestHandler
    {
        public string Name => "AMAZON.StopIntent";

        public SkillResponse Run(Request pRequest)
        {
            return ResponseHelper.CreateTextResponse("Skill stopping");
        }
    }
}
