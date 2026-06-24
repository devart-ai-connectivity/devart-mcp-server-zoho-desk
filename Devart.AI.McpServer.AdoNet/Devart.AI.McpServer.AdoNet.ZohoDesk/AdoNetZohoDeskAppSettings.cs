// --------------------------------------------------------------------------
// <copyright file="AdoNetZohoDeskAppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.AdoNet.ZohoDesk
{
  internal sealed class AdoNetZohoDeskAppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "Zoho Desk";

    public override bool OnPremise => true;
  }
}
