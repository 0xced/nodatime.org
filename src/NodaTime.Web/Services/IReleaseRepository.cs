﻿// Copyright 2016 The Noda Time Authors. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.
using NodaTime.Web.Models;
using System.Collections.Generic;

namespace NodaTime.Web.Services
{
    public interface IReleaseRepository
    {
        IReadOnlyList<ReleaseDownload> AllReleases { get; }
        IReadOnlyList<string> CurrentMinorVersions { get; }
        IReadOnlyList<string> OldMinorVersions { get; }

        /// <summary>
        /// The download file for the latest release. This is always the
        /// binary download, e.g. NodaTime-1.3.4.zip, not the source download.
        /// </summary>
        ReleaseDownload LatestRelease { get; }
    }
}
