// --------------------------------------------------------------------------
// <copyright file="OdbcZohoDeskTools.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using ModelContextProtocol.Server;
using Devart.AI.McpServer.Odbc.ZohoDesk.Tools;

namespace Devart.AI.McpServer.Odbc.ZohoDesk
{
  internal static class OdbcZohoDeskTools
  {
    public static List<McpServerTool> CreateTools(McpConfiguration configuration)
      => OdbcTools.CreateBuilder(configuration)
        .Add(new OdbcZohoDeskPrimaryKeysTool(configuration))
        .Add(new OdbcZohoDeskForeignKeysTool(configuration))
        .Build();
  }
}
