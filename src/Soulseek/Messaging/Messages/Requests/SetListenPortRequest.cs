﻿// <copyright file="SetListenPortRequest.cs" company="JP Dillingham">
//     Copyright (c) JP Dillingham. All rights reserved.
//
//     This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as
//     published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//
//     This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
//     of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the GNU General Public License for more details.
//
//     You should have received a copy of the GNU General Public License along with this program. If not, see https://www.gnu.org/licenses/.
// </copyright>

namespace Soulseek.Messaging.Messages
{
    /// <summary>
    ///     Logs in to the server.
    /// </summary>
    public class SetListenPortRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SetListenPortRequest"/> class.
        /// </summary>
        /// <param name="port">The port on which to listen.</param>
        public SetListenPortRequest(int port)
        {
            Port = port;
        }

        /// <summary>
        ///     Gets the port on which to listen.
        /// </summary>
        public int Port { get; }

        /// <summary>
        ///     Constructs a <see cref="byte"/> array from this message.
        /// </summary>
        /// <returns>The constructed byte array.</returns>
        public byte[] ToByteArray()
        {
            return new MessageBuilder()
                .WriteCode(MessageCode.Server.SetListenPort)
                .WriteInteger(Port)
                .Build();
        }
    }
}