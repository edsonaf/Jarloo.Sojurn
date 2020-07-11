﻿using System.Collections.Generic;
using Jarloo.Sojurn.Models;

namespace Jarloo.Sojurn.InformationProviders
{
    public interface IInformationProvider
    {
        List<Show> GetShows(string search);
        Show GetFullDetails(int showId);
    }
}