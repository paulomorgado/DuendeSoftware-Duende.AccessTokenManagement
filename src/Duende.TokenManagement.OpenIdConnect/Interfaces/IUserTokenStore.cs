// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Duende.TokenManagement.OpenIdConnect
{
    /// <summary>
    /// Storage abstraction for access and refresh tokens
    /// </summary>
    public interface IUserTokenStore
    {
        /// <summary>
        /// Stores tokens
        /// </summary>
        /// <param name="user">User the tokens belong to</param>
        /// <param name="token"></param>
        /// <param name="parameters">Extra optional parameters</param>
        /// <returns></returns>
        Task StoreTokenAsync(
            ClaimsPrincipal user,
            UserAccessToken token,
            UserAccessTokenRequestParameters? parameters = null);

        /// <summary>
        /// Retrieves tokens from store
        /// </summary>
        /// <param name="user">User the tokens belong to</param>
        /// <param name="parameters">Extra optional parameters</param>
        /// <returns>access and refresh token and access token expiration</returns>
        Task<UserAccessToken> GetTokenAsync(
            ClaimsPrincipal user, 
            UserAccessTokenRequestParameters? parameters = null);

        /// <summary>
        /// Clears the stored tokens for a given user
        /// </summary>
        /// <param name="user">User the tokens belong to</param>
        /// <param name="parameters">Extra optional parameters</param>
        /// <returns></returns>
        Task ClearTokenAsync(
            ClaimsPrincipal user, 
            UserAccessTokenRequestParameters? parameters = null);
    }
}