// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Graph;

namespace LocalNetProject.Services
{
    public interface IGraphClientService
    {
        public GraphServiceClient? GetAppGraphClient();
    }
}