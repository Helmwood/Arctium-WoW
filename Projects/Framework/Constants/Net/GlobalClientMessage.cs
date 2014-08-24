﻿/*
 * Copyright (C) 2012-2014 Arctium Emulation <http://arctium.org>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Framework.Constants.Net
{
    // Value '0x2000' means not updated/implemented
    public enum GlobalClientMessage : ushort
    {
        #region UserRouterClient
        SuspendCommsAck      = 0x1876,
        AuthSession          = 0x1B05,
        AuthContinuedSession = 0x1806,
        Ping                 = 0x2000,
        LogDisconnect        = 0x2000,
        SuspendTokenResponse = 0x2000,
        EnableNagle          = 0x2000,
        QueuedMessagesEnd    = 0x2000,
        LogStreamingError    = 0x2000,
        #endregion
    }
}