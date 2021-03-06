﻿using Mobioos.Foundation.Prompt;
using Mobioos.Foundation.Prompt.Infrastructure;
using Mobioos.Scaffold.BaseInfrastructure.Attributes;
using Mobioos.Scaffold.BaseInfrastructure.Services.GeneratorsServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Mobioos.Generators.AspNetCore.Common.Steps
{
    [PromptingStep]
    public class CommonPromptingAuthProvidersStep : StepBodyAsync
    {
        private readonly IPrompting _promptingService;

        public CommonPromptingAuthProvidersStep(IPrompting promptingService)
        {
            _promptingService = promptingService;
        }

        public async override Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            var prompts = new Stack<Question>();
            var authProviderChoices = new List<Choice>
            {
                new Choice { Key = "googleAuth", Value = "googleAuth", Name = "Google OAUTH2" },
                new Choice { Key = "microsoftAuth", Value = "microsoftAuth", Name = "Microsoft" },
                new Choice { Key = "facebookAuth", Value = "facebookAuth", Name = "Facebook" },
                new Choice { Key = "twitterAuth", Value = "twitterAuth", Name = "Twitter" }
            };

            prompts.Push(new ChoiceQuestion()
            {
                Name = "AuthProviders",
                Message = "Choose additional authentication providers",
                Type = QuestionType.Select,
                Choices = authProviderChoices
            });

            await _promptingService.Prompts(nameof(CommonPromptingAuthProvidersStep), prompts, "Select your authentication providers");
            return ExecutionResult.Next();
        }
    }
}
