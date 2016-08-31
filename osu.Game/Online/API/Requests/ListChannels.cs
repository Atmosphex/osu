﻿//Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
//Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.Collections.Generic;
using osu.Game.Online.Chat;

namespace osu.Game.Online.API.Requests
{
    internal class ListChannelsRequest : APIRequest<List<Channel>>
    {
        protected override string Target => @"chat/channels";
    }
}
