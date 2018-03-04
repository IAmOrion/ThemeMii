﻿/* This file is part of ThemeMii
 * Copyright (C) 2009 Leathl
 * 
 * ThemeMii is free software: you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * ThemeMii is distributed in the hope that it will be
 * useful, but WITHOUT ANY WARRANTY; without even the implied warranty
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace ThemeMii
{
    public struct ThemeMiiSettings
    {
        public bool ignoreMissing;
        public bool sourceManage;
        public bool containerManage;
        public bool autoImageSize;
        public bool keepExtractedApp;
        public bool lz77Containers;
        public bool savePrompt;
        public string nandBackupPath;
        public bool saveNandPath;
        public bool saveWindowChanges;
        public bool imageSizeFromTpl;
    }

    public struct AppBrowseInfo
    {
        public bool viewOnly;
        public bool containerBrowse;
        public string selectedNode;
        public bool onlyTpls;
    }

    public struct CreationInfo
    {
        public string savePath;
        public object[] lbEntries;
        public bool createCsm;
        public string nandBackupAppPath;
        public string appFile;
        public bool closeAfter;
    }

    public enum BaseApp : int
    {
        J32 = 0x40,
        U32 = 0x42,
        E32 = 0x45,
        J40 = 0x70,
        U40 = 0x72,
        E40 = 0x75,
        J41 = 0x78,
        U41 = 0x7b,
        E41 = 0x7e,
        J42 = 0x84,
        U42 = 0x87,
        E42 = 0x8a
    }
}
